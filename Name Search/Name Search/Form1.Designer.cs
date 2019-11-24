namespace Name_Search
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
            this.promptBoysName = new System.Windows.Forms.Label();
            this.promptGirlsName = new System.Windows.Forms.Label();
            this.boysNameTextbox = new System.Windows.Forms.TextBox();
            this.girlsNameTextbox = new System.Windows.Forms.TextBox();
            this.commonBoysNameDisplayLabel = new System.Windows.Forms.Label();
            this.commonGirlsNameDisplayLabel = new System.Windows.Forms.Label();
            this.infoIsBoysNameCommon = new System.Windows.Forms.Label();
            this.infoIsGirlsNameCommon = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // promptBoysName
            // 
            this.promptBoysName.AutoSize = true;
            this.promptBoysName.Location = new System.Drawing.Point(4, 9);
            this.promptBoysName.Name = "promptBoysName";
            this.promptBoysName.Size = new System.Drawing.Size(95, 13);
            this.promptBoysName.TabIndex = 0;
            this.promptBoysName.Text = "Enter a boys name";
            // 
            // promptGirlsName
            // 
            this.promptGirlsName.AutoSize = true;
            this.promptGirlsName.Location = new System.Drawing.Point(182, 9);
            this.promptGirlsName.Name = "promptGirlsName";
            this.promptGirlsName.Size = new System.Drawing.Size(91, 13);
            this.promptGirlsName.TabIndex = 1;
            this.promptGirlsName.Text = "Enter a girls name";
            // 
            // boysNameTextbox
            // 
            this.boysNameTextbox.Location = new System.Drawing.Point(7, 34);
            this.boysNameTextbox.Name = "boysNameTextbox";
            this.boysNameTextbox.Size = new System.Drawing.Size(100, 20);
            this.boysNameTextbox.TabIndex = 2;
            // 
            // girlsNameTextbox
            // 
            this.girlsNameTextbox.Location = new System.Drawing.Point(185, 34);
            this.girlsNameTextbox.Name = "girlsNameTextbox";
            this.girlsNameTextbox.Size = new System.Drawing.Size(100, 20);
            this.girlsNameTextbox.TabIndex = 3;
            // 
            // commonBoysNameDisplayLabel
            // 
            this.commonBoysNameDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.commonBoysNameDisplayLabel.Location = new System.Drawing.Point(12, 98);
            this.commonBoysNameDisplayLabel.Name = "commonBoysNameDisplayLabel";
            this.commonBoysNameDisplayLabel.Size = new System.Drawing.Size(100, 23);
            this.commonBoysNameDisplayLabel.TabIndex = 4;
            this.commonBoysNameDisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // commonGirlsNameDisplayLabel
            // 
            this.commonGirlsNameDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.commonGirlsNameDisplayLabel.Location = new System.Drawing.Point(185, 98);
            this.commonGirlsNameDisplayLabel.Name = "commonGirlsNameDisplayLabel";
            this.commonGirlsNameDisplayLabel.Size = new System.Drawing.Size(100, 23);
            this.commonGirlsNameDisplayLabel.TabIndex = 5;
            this.commonGirlsNameDisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // infoIsBoysNameCommon
            // 
            this.infoIsBoysNameCommon.AutoSize = true;
            this.infoIsBoysNameCommon.Location = new System.Drawing.Point(4, 72);
            this.infoIsBoysNameCommon.Name = "infoIsBoysNameCommon";
            this.infoIsBoysNameCommon.Size = new System.Drawing.Size(121, 13);
            this.infoIsBoysNameCommon.TabIndex = 6;
            this.infoIsBoysNameCommon.Text = "Is this a common name?";
            // 
            // infoIsGirlsNameCommon
            // 
            this.infoIsGirlsNameCommon.AutoSize = true;
            this.infoIsGirlsNameCommon.Location = new System.Drawing.Point(170, 72);
            this.infoIsGirlsNameCommon.Name = "infoIsGirlsNameCommon";
            this.infoIsGirlsNameCommon.Size = new System.Drawing.Size(121, 13);
            this.infoIsGirlsNameCommon.TabIndex = 7;
            this.infoIsGirlsNameCommon.Text = "Is this a common name?";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(7, 141);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 8;
            this.searchButton.Text = "&Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.clearButton.Location = new System.Drawing.Point(113, 141);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 9;
            this.clearButton.Text = "C&lear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(216, 141);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.searchButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.clearButton;
            this.ClientSize = new System.Drawing.Size(299, 176);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.infoIsGirlsNameCommon);
            this.Controls.Add(this.infoIsBoysNameCommon);
            this.Controls.Add(this.commonGirlsNameDisplayLabel);
            this.Controls.Add(this.commonBoysNameDisplayLabel);
            this.Controls.Add(this.girlsNameTextbox);
            this.Controls.Add(this.boysNameTextbox);
            this.Controls.Add(this.promptGirlsName);
            this.Controls.Add(this.promptBoysName);
            this.Name = "Form1";
            this.Text = "Name Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label promptBoysName;
        private System.Windows.Forms.Label promptGirlsName;
        private System.Windows.Forms.TextBox boysNameTextbox;
        private System.Windows.Forms.TextBox girlsNameTextbox;
        private System.Windows.Forms.Label commonBoysNameDisplayLabel;
        private System.Windows.Forms.Label commonGirlsNameDisplayLabel;
        private System.Windows.Forms.Label infoIsBoysNameCommon;
        private System.Windows.Forms.Label infoIsGirlsNameCommon;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

