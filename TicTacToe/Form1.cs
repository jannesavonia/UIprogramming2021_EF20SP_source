using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        private List<System.Windows.Forms.Button> btnList;
        public Form1()
        {
            InitializeComponent();

            btnList = new List<System.Windows.Forms.Button>();
            btnList.Add(button11);
            btnList.Add(button12);
            btnList.Add(button13);
            btnList.Add(button21);
            btnList.Add(button22);
            btnList.Add(button23);
            btnList.Add(button31);
            btnList.Add(button32);
            btnList.Add(button33);

            foreach (var b in btnList)
            {
                b.Text = "";
                b.Click += btnClick;
            }

            this.Text = $"{turn} plays";
        }

        string turn = "X";
        private void btnClick(object sender, EventArgs e) {
            var btn = sender as Button;

            if(btn.Text!="")
            {
                return;
            }

            btn.Text = turn;

            if(turn=="X")
            {
                turn = "0";
            } else
            {
                turn = "X"
;            }
            this.Text = $"{turn} plays";
        }
    }
}
