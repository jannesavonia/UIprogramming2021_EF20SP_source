using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DutchAuction
{
    class AuctionItem
    {
        public double startPrice;
        public double reservePrice;
        public string description;
        public string name;
        public AuctionItem(string str)
        {
            var strlist = str.Split('#');
            startPrice = Convert.ToDouble(strlist[0]);
            reservePrice = Convert.ToDouble(strlist[1]);
            description = strlist[2];
            name = strlist[3];
        }
    }

}
