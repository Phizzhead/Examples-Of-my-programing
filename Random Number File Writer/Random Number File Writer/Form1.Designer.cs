namespace Random_Number_File_Writer
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
            this.writeFileButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.randNumberAmmountTextBox = new System.Windows.Forms.TextBox();
            this.amountPromptLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // writeFileButton
            // 
            this.writeFileButton.Location = new System.Drawing.Point(12, 99);
            this.writeFileButton.Name = "writeFileButton";
            this.writeFileButton.Size = new System.Drawing.Size(75, 23);
            this.writeFileButton.TabIndex = 0;
            this.writeFileButton.Text = "&Write File";
            this.writeFileButton.UseVisualStyleBackColor = true;
            this.writeFileButton.Click += new System.EventHandler(this.writeFileButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(218, 99);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // randNumberAmmountTextBox
            // 
            this.randNumberAmmountTextBox.Location = new System.Drawing.Point(256, 9);
            this.randNumberAmmountTextBox.Name = "randNumberAmmountTextBox";
            this.randNumberAmmountTextBox.Size = new System.Drawing.Size(37, 20);
            this.randNumberAmmountTextBox.TabIndex = 2;
            // 
            // amountPromptLabel
            // 
            this.amountPromptLabel.AutoSize = true;
            this.amountPromptLabel.Location = new System.Drawing.Point(12, 12);
            this.amountPromptLabel.Name = "amountPromptLabel";
            this.amountPromptLabel.Size = new System.Drawing.Size(215, 13);
            this.amountPromptLabel.TabIndex = 3;
            this.amountPromptLabel.Text = "Enter Amount Of Numbers To Be Generated";
            // 
            // Form1
            // 
            this.AcceptButton = this.writeFileButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(305, 134);
            this.Controls.Add(this.amountPromptLabel);
            this.Controls.Add(this.randNumberAmmountTextBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.writeFileButton);
            this.Name = "Form1";
            this.Text = "Random Number File Writer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button writeFileButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox randNumberAmmountTextBox;
        private System.Windows.Forms.Label amountPromptLabel;
    }
}

