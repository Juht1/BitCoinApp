namespace BitCoinApp
{
    partial class Form1
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
            this.CurrencyCombo = new System.Windows.Forms.ComboBox();
            this.btnGetRates = new System.Windows.Forms.Button();
            this.amountOfCoinBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CurrencyCombo
            // 
            this.CurrencyCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CurrencyCombo.FormattingEnabled = true;
            this.CurrencyCombo.Items.AddRange(new object[] {
            "USD",
            "EUR"});
            this.CurrencyCombo.Location = new System.Drawing.Point(221, 97);
            this.CurrencyCombo.Margin = new System.Windows.Forms.Padding(4);
            this.CurrencyCombo.Name = "CurrencyCombo";
            this.CurrencyCombo.Size = new System.Drawing.Size(160, 24);
            this.CurrencyCombo.TabIndex = 0;
            // 
            // btnGetRates
            // 
            this.btnGetRates.Location = new System.Drawing.Point(420, 97);
            this.btnGetRates.Margin = new System.Windows.Forms.Padding(4);
            this.btnGetRates.Name = "btnGetRates";
            this.btnGetRates.Size = new System.Drawing.Size(100, 28);
            this.btnGetRates.TabIndex = 1;
            this.btnGetRates.Text = "Get Rates";
            this.btnGetRates.UseVisualStyleBackColor = true;
            this.btnGetRates.Click += new System.EventHandler(this.btnGetRates_Click);
            // 
            // amountOfCoinBox
            // 
            this.amountOfCoinBox.Location = new System.Drawing.Point(221, 197);
            this.amountOfCoinBox.Margin = new System.Windows.Forms.Padding(4);
            this.amountOfCoinBox.Name = "amountOfCoinBox";
            this.amountOfCoinBox.Size = new System.Drawing.Size(132, 22);
            this.amountOfCoinBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(217, 177);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Amount Of Bitcoins";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(221, 230);
            this.resultLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(45, 16);
            this.resultLabel.TabIndex = 4;
            this.resultLabel.Text = "Result";
            this.resultLabel.Visible = false;
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Location = new System.Drawing.Point(221, 251);
            this.ResultTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.Size = new System.Drawing.Size(132, 22);
            this.ResultTextBox.TabIndex = 5;
            this.ResultTextBox.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BitCoinApp.Properties.Resources.Tjagi;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.amountOfCoinBox);
            this.Controls.Add(this.btnGetRates);
            this.Controls.Add(this.CurrencyCombo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "bitcoin kalkulaator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CurrencyCombo;
        private System.Windows.Forms.Button btnGetRates;
        private System.Windows.Forms.TextBox amountOfCoinBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.TextBox ResultTextBox;
    }
}

