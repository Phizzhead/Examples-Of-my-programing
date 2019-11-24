namespace Random_Number_File_Reader
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
            this.numbersListBox = new System.Windows.Forms.ListBox();
            this.readFileButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.infoTotalSum = new System.Windows.Forms.Label();
            this.infoNumbersAmount = new System.Windows.Forms.Label();
            this.numAmountDisplayLabel = new System.Windows.Forms.Label();
            this.totalDisplayBox = new System.Windows.Forms.Label();
            this.openNumberFile = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // numbersListBox
            // 
            this.numbersListBox.FormattingEnabled = true;
            this.numbersListBox.Location = new System.Drawing.Point(12, 12);
            this.numbersListBox.Name = "numbersListBox";
            this.numbersListBox.Size = new System.Drawing.Size(260, 95);
            this.numbersListBox.TabIndex = 0;
            // 
            // readFileButton
            // 
            this.readFileButton.Location = new System.Drawing.Point(12, 226);
            this.readFileButton.Name = "readFileButton";
            this.readFileButton.Size = new System.Drawing.Size(75, 23);
            this.readFileButton.TabIndex = 1;
            this.readFileButton.Text = "&Read File";
            this.readFileButton.UseVisualStyleBackColor = true;
            this.readFileButton.Click += new System.EventHandler(this.readFileButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(105, 226);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "C&lear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(197, 226);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // infoTotalSum
            // 
            this.infoTotalSum.AutoSize = true;
            this.infoTotalSum.Location = new System.Drawing.Point(9, 176);
            this.infoTotalSum.Name = "infoTotalSum";
            this.infoTotalSum.Size = new System.Drawing.Size(55, 13);
            this.infoTotalSum.TabIndex = 4;
            this.infoTotalSum.Text = "Total Sum";
            // 
            // infoNumbersAmount
            // 
            this.infoNumbersAmount.AutoSize = true;
            this.infoNumbersAmount.Location = new System.Drawing.Point(12, 125);
            this.infoNumbersAmount.Name = "infoNumbersAmount";
            this.infoNumbersAmount.Size = new System.Drawing.Size(102, 13);
            this.infoNumbersAmount.TabIndex = 5;
            this.infoNumbersAmount.Text = "Amount Of Numbers";
            // 
            // numAmountDisplayLabel
            // 
            this.numAmountDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.numAmountDisplayLabel.Location = new System.Drawing.Point(120, 124);
            this.numAmountDisplayLabel.Name = "numAmountDisplayLabel";
            this.numAmountDisplayLabel.Size = new System.Drawing.Size(100, 23);
            this.numAmountDisplayLabel.TabIndex = 6;
            this.numAmountDisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalDisplayBox
            // 
            this.totalDisplayBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalDisplayBox.Location = new System.Drawing.Point(120, 166);
            this.totalDisplayBox.Name = "totalDisplayBox";
            this.totalDisplayBox.Size = new System.Drawing.Size(100, 23);
            this.totalDisplayBox.TabIndex = 7;
            this.totalDisplayBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AcceptButton = this.readFileButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.clearButton;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.totalDisplayBox);
            this.Controls.Add(this.numAmountDisplayLabel);
            this.Controls.Add(this.infoNumbersAmount);
            this.Controls.Add(this.infoTotalSum);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.readFileButton);
            this.Controls.Add(this.numbersListBox);
            this.Name = "Form1";
            this.Text = "Random Number File Reader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox numbersListBox;
        private System.Windows.Forms.Button readFileButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label infoTotalSum;
        private System.Windows.Forms.Label infoNumbersAmount;
        private System.Windows.Forms.Label numAmountDisplayLabel;
        private System.Windows.Forms.Label totalDisplayBox;
        private System.Windows.Forms.OpenFileDialog openNumberFile;
    }
}

