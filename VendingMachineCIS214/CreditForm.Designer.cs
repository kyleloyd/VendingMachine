namespace VendingMachineCIS214
{
    partial class CreditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.creditAmountTextBox = new System.Windows.Forms.TextBox();
            this.cardNoTextBox = new System.Windows.Forms.TextBox();
            this.checkButton = new System.Windows.Forms.Button();
            this.doneCreditButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Last 4 of Card #: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter the amount: ";
            // 
            // creditAmountTextBox
            // 
            this.creditAmountTextBox.Location = new System.Drawing.Point(125, 6);
            this.creditAmountTextBox.Name = "creditAmountTextBox";
            this.creditAmountTextBox.Size = new System.Drawing.Size(82, 20);
            this.creditAmountTextBox.TabIndex = 3;
            // 
            // cardNoTextBox
            // 
            this.cardNoTextBox.Location = new System.Drawing.Point(135, 32);
            this.cardNoTextBox.Name = "cardNoTextBox";
            this.cardNoTextBox.Size = new System.Drawing.Size(72, 20);
            this.cardNoTextBox.TabIndex = 4;
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(15, 95);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(104, 23);
            this.checkButton.TabIndex = 5;
            this.checkButton.Text = "Check Balance";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // doneCreditButton
            // 
            this.doneCreditButton.Enabled = false;
            this.doneCreditButton.Location = new System.Drawing.Point(125, 95);
            this.doneCreditButton.Name = "doneCreditButton";
            this.doneCreditButton.Size = new System.Drawing.Size(82, 23);
            this.doneCreditButton.TabIndex = 6;
            this.doneCreditButton.Text = "Done";
            this.doneCreditButton.UseVisualStyleBackColor = true;
            this.doneCreditButton.Click += new System.EventHandler(this.doneCreditButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Status:";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(90, 64);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 13);
            this.statusLabel.TabIndex = 10;
            // 
            // CreditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 125);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.doneCreditButton);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.cardNoTextBox);
            this.Controls.Add(this.creditAmountTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreditForm";
            this.Text = "Use Credit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox creditAmountTextBox;
        private System.Windows.Forms.TextBox cardNoTextBox;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Button doneCreditButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label statusLabel;
    }
}