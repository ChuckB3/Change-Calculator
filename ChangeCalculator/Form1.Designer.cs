namespace ChangeCalculator
{
    partial class Change_Calculator
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
            this.priceLabel = new System.Windows.Forms.Label();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tenderLabel = new System.Windows.Forms.Label();
            this.tenderBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(89, 9);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(84, 13);
            this.priceLabel.TabIndex = 0;
            this.priceLabel.Text = "Enter total price:";
            this.priceLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(79, 25);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(100, 20);
            this.priceBox.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tenderLabel
            // 
            this.tenderLabel.AutoSize = true;
            this.tenderLabel.Location = new System.Drawing.Point(70, 48);
            this.tenderLabel.Name = "tenderLabel";
            this.tenderLabel.Size = new System.Drawing.Size(118, 13);
            this.tenderLabel.TabIndex = 3;
            this.tenderLabel.Text = "Enter amount tendered:";
            // 
            // tenderBox
            // 
            this.tenderBox.Location = new System.Drawing.Point(79, 64);
            this.tenderBox.Name = "tenderBox";
            this.tenderBox.Size = new System.Drawing.Size(100, 20);
            this.tenderBox.TabIndex = 4;
            // 
            // Change_Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 127);
            this.Controls.Add(this.tenderBox);
            this.Controls.Add(this.tenderLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.priceLabel);
            this.Name = "Change_Calculator";
            this.ShowIcon = false;
            this.Text = "Change Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label tenderLabel;
        private System.Windows.Forms.TextBox tenderBox;
    }
}

