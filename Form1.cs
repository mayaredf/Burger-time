using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
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
        double cashNumber = 0;
        double change = 0;

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
            friesNumber = Convert.ToInt16(friesBox.Text);
            drinkNumber = Convert.ToInt16(drinkBox.Text);


            subTotal = burgerNumber * BURGER_BASE_COST + friesNumber * FRIES_BASE_COST + drinkNumber * DRINK_BASE_COST;
            taxTotal = subTotal * tax;
            total = subTotal + taxTotal;

            subTotalLabel.Text = subTotal.ToString("C");
            taxLabel.Text = taxTotal.ToString("C") ;
            totalLabel.Text = total.ToString("C");

            
        }


        private void changeButton_Click(object sender, EventArgs e)
        {
            cashNumber = Convert.ToInt16(cashBox.Text);

            change = cashNumber - total;
            changeLabel.Text = change.ToString("C");
         

        }

        private void printButton_Click(object sender, EventArgs e)
        {
            Graphics formGraphics = this.CreateGraphics();
            Font drawFont = new Font("Consolas", 10);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            formGraphics.DrawString("Burger Time Inc.", drawFont, drawBrush, 320, 40);
            Thread.Sleep(200);
            formGraphics.DrawString("Order Number 346", drawFont, drawBrush, 270, 80);
        }

        private void newButton_Click(object sender, EventArgs e)
        {

        }
    }
}
