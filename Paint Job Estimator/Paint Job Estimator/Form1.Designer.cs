namespace Paint_Job_Estimator
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
            this.promptSquareFeetLabel = new System.Windows.Forms.Label();
            this.squareFeetTextBox = new System.Windows.Forms.TextBox();
            this.propmtGallonsLabel = new System.Windows.Forms.Label();
            this.gallonsTextBox = new System.Windows.Forms.TextBox();
            this.infoGallonsRequired = new System.Windows.Forms.Label();
            this.displayGallonsRequired = new System.Windows.Forms.Label();
            this.infoLaborRequired = new System.Windows.Forms.Label();
            this.displayLaborHours = new System.Windows.Forms.Label();
            this.infoPaintCostLabel = new System.Windows.Forms.Label();
            this.displayPaintCostLabel = new System.Windows.Forms.Label();
            this.infoLaborCost = new System.Windows.Forms.Label();
            this.displayLaborCostLabel = new System.Windows.Forms.Label();
            this.infoTotalCostLabel = new System.Windows.Forms.Label();
            this.displayTotalCostLabel = new System.Windows.Forms.Label();
            this.caculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // promptSquareFeetLabel
            // 
            this.promptSquareFeetLabel.AutoSize = true;
            this.promptSquareFeetLabel.Location = new System.Drawing.Point(12, 9);
            this.promptSquareFeetLabel.Name = "promptSquareFeetLabel";
            this.promptSquareFeetLabel.Size = new System.Drawing.Size(164, 13);
            this.promptSquareFeetLabel.TabIndex = 10;
            this.promptSquareFeetLabel.Text = "Enter Square Feet To Be Painted";
            // 
            // squareFeetTextBox
            // 
            this.squareFeetTextBox.Location = new System.Drawing.Point(182, 6);
            this.squareFeetTextBox.Name = "squareFeetTextBox";
            this.squareFeetTextBox.Size = new System.Drawing.Size(100, 20);
            this.squareFeetTextBox.TabIndex = 0;
            // 
            // propmtGallonsLabel
            // 
            this.propmtGallonsLabel.AutoSize = true;
            this.propmtGallonsLabel.Location = new System.Drawing.Point(27, 33);
            this.propmtGallonsLabel.Name = "propmtGallonsLabel";
            this.propmtGallonsLabel.Size = new System.Drawing.Size(149, 13);
            this.propmtGallonsLabel.TabIndex = 11;
            this.propmtGallonsLabel.Text = "Enter Cost of a Gallon of Paint";
            // 
            // gallonsTextBox
            // 
            this.gallonsTextBox.Location = new System.Drawing.Point(182, 30);
            this.gallonsTextBox.Name = "gallonsTextBox";
            this.gallonsTextBox.Size = new System.Drawing.Size(100, 20);
            this.gallonsTextBox.TabIndex = 1;
            // 
            // infoGallonsRequired
            // 
            this.infoGallonsRequired.Location = new System.Drawing.Point(12, 81);
            this.infoGallonsRequired.Name = "infoGallonsRequired";
            this.infoGallonsRequired.Size = new System.Drawing.Size(100, 23);
            this.infoGallonsRequired.TabIndex = 12;
            this.infoGallonsRequired.Text = "Gallons Required";
            this.infoGallonsRequired.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // displayGallonsRequired
            // 
            this.displayGallonsRequired.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.displayGallonsRequired.Location = new System.Drawing.Point(118, 81);
            this.displayGallonsRequired.Name = "displayGallonsRequired";
            this.displayGallonsRequired.Size = new System.Drawing.Size(100, 23);
            this.displayGallonsRequired.TabIndex = 2;
            this.displayGallonsRequired.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // infoLaborRequired
            // 
            this.infoLaborRequired.Location = new System.Drawing.Point(12, 113);
            this.infoLaborRequired.Name = "infoLaborRequired";
            this.infoLaborRequired.Size = new System.Drawing.Size(100, 23);
            this.infoLaborRequired.TabIndex = 13;
            this.infoLaborRequired.Text = "Labor Hours";
            this.infoLaborRequired.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // displayLaborHours
            // 
            this.displayLaborHours.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.displayLaborHours.Location = new System.Drawing.Point(118, 113);
            this.displayLaborHours.Name = "displayLaborHours";
            this.displayLaborHours.Size = new System.Drawing.Size(100, 23);
            this.displayLaborHours.TabIndex = 3;
            this.displayLaborHours.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // infoPaintCostLabel
            // 
            this.infoPaintCostLabel.Location = new System.Drawing.Point(12, 146);
            this.infoPaintCostLabel.Name = "infoPaintCostLabel";
            this.infoPaintCostLabel.Size = new System.Drawing.Size(100, 23);
            this.infoPaintCostLabel.TabIndex = 14;
            this.infoPaintCostLabel.Text = "Paint Cost";
            this.infoPaintCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // displayPaintCostLabel
            // 
            this.displayPaintCostLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.displayPaintCostLabel.Location = new System.Drawing.Point(118, 146);
            this.displayPaintCostLabel.Name = "displayPaintCostLabel";
            this.displayPaintCostLabel.Size = new System.Drawing.Size(100, 23);
            this.displayPaintCostLabel.TabIndex = 4;
            this.displayPaintCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // infoLaborCost
            // 
            this.infoLaborCost.Location = new System.Drawing.Point(12, 179);
            this.infoLaborCost.Name = "infoLaborCost";
            this.infoLaborCost.Size = new System.Drawing.Size(100, 23);
            this.infoLaborCost.TabIndex = 15;
            this.infoLaborCost.Text = "Labor Cost";
            this.infoLaborCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // displayLaborCostLabel
            // 
            this.displayLaborCostLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.displayLaborCostLabel.Location = new System.Drawing.Point(118, 179);
            this.displayLaborCostLabel.Name = "displayLaborCostLabel";
            this.displayLaborCostLabel.Size = new System.Drawing.Size(100, 23);
            this.displayLaborCostLabel.TabIndex = 5;
            this.displayLaborCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // infoTotalCostLabel
            // 
            this.infoTotalCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoTotalCostLabel.Location = new System.Drawing.Point(12, 211);
            this.infoTotalCostLabel.Name = "infoTotalCostLabel";
            this.infoTotalCostLabel.Size = new System.Drawing.Size(100, 23);
            this.infoTotalCostLabel.TabIndex = 16;
            this.infoTotalCostLabel.Text = "Total Cost";
            this.infoTotalCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // displayTotalCostLabel
            // 
            this.displayTotalCostLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.displayTotalCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayTotalCostLabel.Location = new System.Drawing.Point(118, 211);
            this.displayTotalCostLabel.Name = "displayTotalCostLabel";
            this.displayTotalCostLabel.Size = new System.Drawing.Size(100, 23);
            this.displayTotalCostLabel.TabIndex = 6;
            this.displayTotalCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // caculateButton
            // 
            this.caculateButton.Location = new System.Drawing.Point(12, 265);
            this.caculateButton.Name = "caculateButton";
            this.caculateButton.Size = new System.Drawing.Size(75, 39);
            this.caculateButton.TabIndex = 7;
            this.caculateButton.Text = "Cac&ulate Cost";
            this.caculateButton.UseVisualStyleBackColor = true;
            this.caculateButton.Click += new System.EventHandler(this.caculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(118, 265);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(58, 39);
            this.clearButton.TabIndex = 8;
            this.clearButton.Text = "C&lear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(209, 265);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 39);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.caculateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(296, 316);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.caculateButton);
            this.Controls.Add(this.displayTotalCostLabel);
            this.Controls.Add(this.infoTotalCostLabel);
            this.Controls.Add(this.displayLaborCostLabel);
            this.Controls.Add(this.infoLaborCost);
            this.Controls.Add(this.displayPaintCostLabel);
            this.Controls.Add(this.infoPaintCostLabel);
            this.Controls.Add(this.displayLaborHours);
            this.Controls.Add(this.infoLaborRequired);
            this.Controls.Add(this.displayGallonsRequired);
            this.Controls.Add(this.infoGallonsRequired);
            this.Controls.Add(this.gallonsTextBox);
            this.Controls.Add(this.propmtGallonsLabel);
            this.Controls.Add(this.squareFeetTextBox);
            this.Controls.Add(this.promptSquareFeetLabel);
            this.Name = "Form1";
            this.Text = "Paint Job Estimator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label promptSquareFeetLabel;
        private System.Windows.Forms.TextBox squareFeetTextBox;
        private System.Windows.Forms.Label propmtGallonsLabel;
        private System.Windows.Forms.TextBox gallonsTextBox;
        private System.Windows.Forms.Label infoGallonsRequired;
        private System.Windows.Forms.Label displayGallonsRequired;
        private System.Windows.Forms.Label infoLaborRequired;
        private System.Windows.Forms.Label displayLaborHours;
        private System.Windows.Forms.Label infoPaintCostLabel;
        private System.Windows.Forms.Label displayPaintCostLabel;
        private System.Windows.Forms.Label infoLaborCost;
        private System.Windows.Forms.Label displayLaborCostLabel;
        private System.Windows.Forms.Label infoTotalCostLabel;
        private System.Windows.Forms.Label displayTotalCostLabel;
        private System.Windows.Forms.Button caculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

