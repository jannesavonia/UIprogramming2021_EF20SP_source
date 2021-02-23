using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
    public partial class Form1 : Form
    {
        private double startPrice;
        private double reservePrice;
        private double currentPrice;
        private const string ItemsFile = "../../Items.txt";
        private List<AuctionItem> itemList = new List<AuctionItem>();
        //private int itemNumber=-1;
        public Form1()
        {
            var items=File.ReadAllLines(ItemsFile);
            foreach(var item in items)
            {
                itemList.Add(new AuctionItem(item));
            }
            InitializeComponent();
            NextItem();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            currentPrice = startPrice;
            priceLabel.Text = PriceString();
            bidButton.Enabled = true;
            nextButton.Enabled = false;
            startButton.Enabled = false;
            timer1.Start();
        }
        private string PriceString()
        {
            return currentPrice.ToString("0.00 €");
        }

        private void bidButton_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            String name = Prompt.ShowDialog("Name of a bidder?", "Asking...");
            itemInfoTextBox.AppendText(Environment.NewLine);
            itemInfoTextBox.AppendText("Buyer: " + name + Environment.NewLine);
            itemInfoTextBox.AppendText("Bid: " + PriceString());
            startButton.Enabled = false;
            bidButton.Enabled = false;
            nextButton.Enabled = (itemList.Count != 0);
        }
        private void NextItem()
        {
            //itemNumber++;
            startButton.Enabled = true;
            bidButton.Enabled = false;
            itemInfoTextBox.Clear();
            priceLabel.Text = "";
            if (itemList.Count > 0)
            {
                var it = itemList.ElementAt(0);
                itemList.RemoveAt(0);
                startPrice = it.startPrice;
                reservePrice = it.reservePrice;
                itemInfoTextBox.AppendText(it.name + Environment.NewLine);
                itemInfoTextBox.AppendText(Environment.NewLine);
                itemInfoTextBox.AppendText(it.description + Environment.NewLine);
            }
            nextButton.Enabled = (itemList.Count!=0);
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            NextItem();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            currentPrice -= startPrice * 0.01;
            priceLabel.Text = PriceString();
            if(currentPrice<reservePrice)
            {
                timer1.Stop();
                startButton.Enabled = false;
                bidButton.Enabled = false;
                nextButton.Enabled = (itemList.Count != 0);
                priceLabel.Text = "";
            }
        }
    }
}
