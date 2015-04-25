using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendingMachineCIS214
{
    public partial class CashForm : Form
    {
        private double currentDollars = 0;
        private double currentCents = 0;

        public CashForm()
        {
            InitializeComponent();
        }

        public string getCashTotal() {
            double currentTotal = currentDollars + (currentCents / 100);
            return currentTotal.ToString();
        }

        private void displayAmount(double dollars, double cents)
        {
            amountTextBox.Text = "$" + string.Format("{0:0.##}", getCashTotal());
        }

        private void nickelButton_Click(object sender, EventArgs e)
        {
            addChange(5);
        }

        private void dimeButton_Click(object sender, EventArgs e)
        {
            addChange(10);
        }

        private void quarterButton_Click(object sender, EventArgs e)
        {
            addChange(25);
        }

        //Centralized method for all change adding to total;
        private void addChange(int value) {
            //Case: Nickel;
            if (value == 5) {
                //Conditional for rounding up to next dollar if necessary;
                if (currentCents + 5 >= 100)
                {
                    currentCents = (currentCents + 5) - 100;
                    currentDollars++;
                }

                else
                {
                    currentCents += 5;
                }
            }
            
            //Case: Dime;
            else if (value == 10) {
                if (currentCents + 10 >= 100)
                {
                    currentCents = (currentCents + 10) - 100;
                    currentDollars++;
                }

                else
                {
                    currentCents += 10;
                }
            }

            //Case: Quarter;
            else {
                if (currentCents + 25 >= 100)
                {
                    currentCents = (currentCents + 25) - 100;
                    currentDollars++;
                }

                else
                {
                    currentCents += 25;
                }
            }

            displayAmount(currentDollars, currentCents);
        }

        private void oneButton_Click(object sender, EventArgs e)
        {
            currentDollars += 1;
            displayAmount(currentDollars, currentCents);
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            currentDollars += 5;
            displayAmount(currentDollars, currentCents);
        }

        private void cashDoneButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
