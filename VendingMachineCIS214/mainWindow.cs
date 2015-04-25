using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendingMachineCIS214 {
    public partial class mainWindow : Form {
        public string currentVendingBalance;

        public mainWindow() {
            InitializeComponent();
        }

        // Interaction with Credit/Cash interfaces;
        private void useCashButton_Click(object sender, EventArgs e) {
            CashForm form2 = new CashForm();
            form2.ShowDialog();
            useCashButton.Enabled = false;
            useCreditButton.Enabled = false;
            currentVendingBalance = form2.getCashTotal();
            updateTextBox();
            updateButtons();
        }

        private void useCreditButton_Click(object sender, EventArgs e) {
            CreditForm form2 = new CreditForm();
            form2.ShowDialog();
            useCashButton.Enabled = false;
            useCreditButton.Enabled = false;
            currentVendingBalance = form2.getCreditAmount();
            updateTextBox();
            updateButtons();
        }

        // Update mainWindow after payment method;
        private void updateTextBox() {
            mainAmountTextBox.Text = "$" + currentVendingBalance;
        }

        private void updateButtons() {
            double balance = Double.Parse(currentVendingBalance);
            resetAllRows();
            if (balance < .8) {
                MessageBox.Show("Thank you, have a nice day!");
                this.Close();
            }
            else if (balance >= .8 && balance < 1)
            {
                enableRowOne();
            }

            else if (balance >= 1 && balance < 1.25)
            {
                enableRowOne();
                enableRowTwo();
            }

            else if (balance >= 1.25 && balance < 1.5)
            {
                enableRowOne();
                enableRowTwo();
                enableRowThree();
            }

            else
            {
                enableRowOne();
                enableRowTwo();
                enableRowThree();
                enableRowFour();
            }
        }

        private void enableRowOne() 
        {
            A1Button.Enabled = true;
            A2Button.Enabled = true;
            A3Button.Enabled = true;
            A4Button.Enabled = true;
            A5Button.Enabled = true;
        }

        private void enableRowTwo()
        {
            B1Button.Enabled = true;
            B2Button.Enabled = true;
            B3Button.Enabled = true;
            B4Button.Enabled = true;
            B5Button.Enabled = true;
        }

        private void enableRowThree()
        {
            C1Button.Enabled = true;
            C2Button.Enabled = true;
            C3Button.Enabled = true;
            C4Button.Enabled = true;
            C5Button.Enabled = true;
        }

        private void enableRowFour()
        {
            D1Button.Enabled = true;
            D2Button.Enabled = true;
            D3Button.Enabled = true;
            D4Button.Enabled = true;
            D5Button.Enabled = true;
        }

        private void resetAllRows() 
        {
            A1Button.Enabled = false;
            A2Button.Enabled = false;
            A3Button.Enabled = false;
            A4Button.Enabled = false;
            A5Button.Enabled = false;
            B1Button.Enabled = false;
            B2Button.Enabled = false;
            B3Button.Enabled = false;
            B4Button.Enabled = false;
            B5Button.Enabled = false;
            C1Button.Enabled = false;
            C2Button.Enabled = false;
            C3Button.Enabled = false;
            C4Button.Enabled = false;
            C5Button.Enabled = false;
            D1Button.Enabled = false;
            D2Button.Enabled = false;
            D3Button.Enabled = false;
            D4Button.Enabled = false;
            D5Button.Enabled = false;
        }

        private void selectionButtonEvent(string name, double cost)
        {
            double newBalance = Double.Parse(currentVendingBalance) - cost;
            currentVendingBalance = newBalance.ToString();

            DialogResult result = MessageBox.Show("Enjoy your " + name + "!");
            if (result == DialogResult.OK)
            {
                updateTextBox();
                updateButtons();
            }
        }
        
        // Ordering Methods
        private void A1Button_Click(object sender, EventArgs e)
        {
            selectionButtonEvent(Inventory.A1.getProductName(), .8);
        }

        private void A2Button_Click(object sender, EventArgs e)
        {
            selectionButtonEvent(Inventory.A2.getProductName(), .8);
        }

        private void A3Button_Click(object sender, EventArgs e)
        {
            selectionButtonEvent(Inventory.A3.getProductName(), .8);
        }

        private void A4Button_Click(object sender, EventArgs e)
        {
            selectionButtonEvent(Inventory.A4.getProductName(), .8);
        }

        private void A5Button_Click(object sender, EventArgs e)
        {
            selectionButtonEvent(Inventory.A5.getProductName(), .8);
        }

        
        private void B1Button_Click(object sender, EventArgs e)
        {
            selectionButtonEvent(Inventory.B1.getProductName(), 1);
        }

        private void B2Button_Click(object sender, EventArgs e)
        {
            selectionButtonEvent(Inventory.B2.getProductName(), 1);
        }

        private void B3Button_Click(object sender, EventArgs e)
        {
            selectionButtonEvent(Inventory.B3.getProductName(), 1);
        }

        private void B4Button_Click(object sender, EventArgs e)
        {
            selectionButtonEvent(Inventory.B4.getProductName(), 1);
        }

        private void B5Button_Click(object sender, EventArgs e)
        {
            selectionButtonEvent(Inventory.B5.getProductName(), 1);
        }

        
        private void C1Button_Click(object sender, EventArgs e)
        {
            selectionButtonEvent(Inventory.C1.getProductName(), 1.25);
        }

        private void C2Button_Click(object sender, EventArgs e)
        {
            selectionButtonEvent(Inventory.C2.getProductName(), 1.25);
        }

        private void C3Button_Click(object sender, EventArgs e)
        {
            selectionButtonEvent(Inventory.C3.getProductName(), 1.25);
        }

        private void C4Button_Click(object sender, EventArgs e)
        {
            selectionButtonEvent(Inventory.C4.getProductName(), 1.25);
        }

        private void C5Button_Click(object sender, EventArgs e)
        {
            selectionButtonEvent(Inventory.C5.getProductName(), 1.25);
        }

        
        private void D1Button_Click(object sender, EventArgs e)
        {
            selectionButtonEvent(Inventory.D1.getProductName(), 1.5);
        }

        private void D2Button_Click(object sender, EventArgs e)
        {
            selectionButtonEvent(Inventory.D2.getProductName(), 1.5);
        }

        private void D3Button_Click(object sender, EventArgs e)
        {
            selectionButtonEvent(Inventory.D3.getProductName(), 1.5);
        }

        private void D4Button_Click(object sender, EventArgs e)
        {
            selectionButtonEvent(Inventory.D4.getProductName(), 1.5);
        }

        private void D5Button_Click(object sender, EventArgs e)
        {
            selectionButtonEvent(Inventory.D5.getProductName(), 1.5);
        }
    }
}
