using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ChangeCalculator
{
    public partial class Change_Calculator : Form
    {
        public double twenties;
        public double tens;
        public double fives;
        public double ones;
        public double quarters;
        public double dimes;
        public double nickels;
        public double pennies;
        public double change;
        public double price;
        public double tendered;
        public double changeCount;

        public Change_Calculator()
        {
            InitializeComponent();
        }

        public String calcChange(double n)
        {
            changeCount = 0;
            twenties = Math.Floor(n / 20);
            changeCount += (twenties*20);
            tens = Math.Floor((n-changeCount) / 10);
            changeCount += (tens * 10);
            fives = Math.Floor((n - changeCount) / 5);
            changeCount += (fives * 5);
            ones = Math.Floor((n - changeCount) / 1);
            changeCount += (ones * 1);
            quarters = Math.Floor((n - changeCount) / .25);
            changeCount += (quarters * .25);
            dimes = Math.Floor((n - changeCount) / .10);
            changeCount += (dimes * .10);
            nickels = Math.Floor((n - changeCount) / .05);
            changeCount += (nickels * .05);
            pennies = Math.Ceiling((n - changeCount) / .01);
            changeCount += (pennies * .01);


            return "$20: " + twenties + "\n"
                + "$10: " + tens + "\n"
                + "$5: " + fives + "\n"
                + "$1: " + ones + "\n"
                + "$0.25: " + quarters + "\n"
                + "$0.10: " + dimes + "\n"
                + "$0.05: " + nickels + "\n"
                + "$0.01: " + pennies + "\n";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            price = double.Parse(priceBox.Text);
            tendered = double.Parse(tenderBox.Text);

            if (tendered >= price)
            {
                change = tendered - price;
                MessageBox.Show(calcChange(change), "Change");
            }
            else
            {
                MessageBox.Show("Customer owes $" + (price - tendered), "Error");
            }

        }
    }
}
