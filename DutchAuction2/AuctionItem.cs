using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace DutchAuction2
{
    class AuctionItem
    {
        public double startPrice;
        public double reservePrice;
        public string description;
        public string name;
        public AuctionItem(string str)
        {
            NumberFormatInfo nfi = new NumberFormatInfo();
            nfi.NumberDecimalSeparator = ".";


            var strlist = str.Split('#');
            startPrice = Convert.ToDouble(strlist[0], nfi);
            reservePrice = Convert.ToDouble(strlist[1], nfi);
            description = strlist[2];
            name = strlist[3];
        }
    }
}
