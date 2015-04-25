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
    public partial class CreditForm : Form
    {
        public CreditForm()
        {
            InitializeComponent();
        }

        //Checks current balance against stored data;
        //Returns true if adequate balance; False if inadequate;
        private void checkButton_Click(object sender, EventArgs e)
        {
            if (Bank.checkAdequateBalance(Int32.Parse(cardNoTextBox.Text), Double.Parse(creditAmountTextBox.Text))) 
            {
                statusLabel.ForeColor = System.Drawing.Color.Green;
                statusLabel.Text = "APPROVED";
                doneCreditButton.Enabled = true;
            }

            else 
            {
                statusLabel.ForeColor = System.Drawing.Color.DarkRed;
                statusLabel.Text = "DECLINED";
                creditAmountTextBox.Clear();
                cardNoTextBox.Clear();
            }
        }

        //Passes monetary value as return value and closes CreditForm form.
        public void doneCreditButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string getCreditAmount() {
            if (creditAmountTextBox.Text == "")
            {
                return "0.00";
            }
            else 
            {
                return string.Format("{0:0.##}", creditAmountTextBox.Text);
            }
        }
    }
}
