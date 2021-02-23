using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DutchAuction
{
    public partial class Form1 : Form
    {
        double startPrice;
        double reservePrice;
        double currentPrice;
        double bid; 
        public Form1()
        {
            InitializeComponent();
            NextItem();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            startPrice = 1000;
            currentPrice = startPrice;
            reservePrice = 900;
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
            itemInfoTextBox.AppendText("Buyer: " + name + Environment.NewLine);
            itemInfoTextBox.AppendText("Bid: " + PriceString());
            startButton.Enabled = false;
            bidButton.Enabled = false;
            nextButton.Enabled = true;
        }

        private void NextItem()
        {
            startButton.Enabled = true;
            bidButton.Enabled = false;
            nextButton.Enabled = true;
            itemInfoTextBox.Clear();
            priceLabel.Text = "";
            itemInfoTextBox.AppendText("Item to sell"+ Environment.NewLine);
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
                nextButton.Enabled = true;
                priceLabel.Text = "";
            }
        }
    }
}
