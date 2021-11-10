
namespace Unit_Conversions
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
            this.infoLabel = new System.Windows.Forms.Label();
            this.choiceBox = new System.Windows.Forms.TextBox();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.choiceLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // infoLabel
            // 
            this.infoLabel.Location = new System.Drawing.Point(34, 23);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(241, 107);
            this.infoLabel.TabIndex = 0;
            this.infoLabel.Text = "Imperial to Metric Conversion\r\n\r\n\r\n1. Inches to cm\r\n2. Feet to cm\r\n3. Yards to m\r" +
    "\n4. Miles to km";
            this.infoLabel.Click += new System.EventHandler(this.infoLabel_Click);
            // 
            // choiceBox
            // 
            this.choiceBox.Location = new System.Drawing.Point(182, 133);
            this.choiceBox.Name = "choiceBox";
            this.choiceBox.Size = new System.Drawing.Size(100, 20);
            this.choiceBox.TabIndex = 1;
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(182, 159);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(100, 20);
            this.inputBox.TabIndex = 2;
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(93, 185);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(138, 31);
            this.convertButton.TabIndex = 3;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.Location = new System.Drawing.Point(34, 228);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(248, 26);
            this.outputLabel.TabIndex = 4;
            // 
            // choiceLabel
            // 
            this.choiceLabel.AutoSize = true;
            this.choiceLabel.Location = new System.Drawing.Point(31, 136);
            this.choiceLabel.Name = "choiceLabel";
            this.choiceLabel.Size = new System.Drawing.Size(145, 13);
            this.choiceLabel.TabIndex = 5;
            this.choiceLabel.Text = "Choose your conversion (1-4)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter the value to convert";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 277);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.choiceLabel);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.choiceBox);
            this.Controls.Add(this.infoLabel);
            this.Name = "Form1";
            this.Text = "Imperial To Metric  ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.TextBox choiceBox;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label choiceLabel;
        private System.Windows.Forms.Label label1;
    }
}

