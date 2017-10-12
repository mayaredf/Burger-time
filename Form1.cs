using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//This program was made by Maya Redford-Haines
//October 10th, 2017


namespace Burger_time
{
    public partial class Form1 : Form

        
    {
        const double BURGER_BASE_COST = 2.49;
        int burgerNumber = 0;
        const double FRIES_BASE_COST = 1.89;
        int friesNumber = 0;
        const double DRINK_BASE_COST = 0.99;
        int drinkNumber = 0;
        const double tax = 0.13;

        double subTotal = 0;
        double taxTotal = 0;
        double total = 0;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            burgerNumber = Convert.ToInt16(burgerBox.Text);
            subTotal = Convert.ToInt16(subTotalLabel.Text);


            subTotal = burgerNumber * BURGER_BASE_COST + friesNumber * FRIES_BASE_COST;
            taxTotal = subTotal * tax;
            total = subTotal + taxTotal;

           // subTotalLabel.Text = subTotal;
            //taxLabel.Text = ;
            //totalLabel.Text = ;

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void printButton_Click(object sender, EventArgs e)
        {

        }

        private void newButton_Click(object sender, EventArgs e)
        {

        }
    }
}
