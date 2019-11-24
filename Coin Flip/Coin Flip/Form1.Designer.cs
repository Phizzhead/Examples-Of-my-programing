namespace Coin_Flip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.headsPictureBox = new System.Windows.Forms.PictureBox();
            this.tailsPictureBox = new System.Windows.Forms.PictureBox();
            this.showHeadsButton = new System.Windows.Forms.Button();
            this.showTailsButton = new System.Windows.Forms.Button();
            this.formCloseButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.headsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tailsPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // headsPictureBox
            // 
            this.headsPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("headsPictureBox.Image")));
            this.headsPictureBox.Location = new System.Drawing.Point(12, 12);
            this.headsPictureBox.Name = "headsPictureBox";
            this.headsPictureBox.Size = new System.Drawing.Size(125, 111);
            this.headsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.headsPictureBox.TabIndex = 0;
            this.headsPictureBox.TabStop = false;
            this.headsPictureBox.Visible = false;
            // 
            // tailsPictureBox
            // 
            this.tailsPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("tailsPictureBox.Image")));
            this.tailsPictureBox.Location = new System.Drawing.Point(146, 12);
            this.tailsPictureBox.Name = "tailsPictureBox";
            this.tailsPictureBox.Size = new System.Drawing.Size(125, 111);
            this.tailsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tailsPictureBox.TabIndex = 1;
            this.tailsPictureBox.TabStop = false;
            this.tailsPictureBox.Visible = false;
            // 
            // showHeadsButton
            // 
            this.showHeadsButton.Location = new System.Drawing.Point(12, 140);
            this.showHeadsButton.Name = "showHeadsButton";
            this.showHeadsButton.Size = new System.Drawing.Size(78, 34);
            this.showHeadsButton.TabIndex = 2;
            this.showHeadsButton.Text = "Show Heads";
            this.showHeadsButton.UseVisualStyleBackColor = true;
            this.showHeadsButton.Click += new System.EventHandler(this.showHeadsButton_Click);
            // 
            // showTailsButton
            // 
            this.showTailsButton.Location = new System.Drawing.Point(104, 140);
            this.showTailsButton.Name = "showTailsButton";
            this.showTailsButton.Size = new System.Drawing.Size(77, 34);
            this.showTailsButton.TabIndex = 3;
            this.showTailsButton.Text = "Show Tails";
            this.showTailsButton.UseVisualStyleBackColor = true;
            this.showTailsButton.Click += new System.EventHandler(this.showTailsButton_Click);
            // 
            // formCloseButton
            // 
            this.formCloseButton.Location = new System.Drawing.Point(194, 140);
            this.formCloseButton.Name = "formCloseButton";
            this.formCloseButton.Size = new System.Drawing.Size(77, 34);
            this.formCloseButton.TabIndex = 4;
            this.formCloseButton.Text = "Exit";
            this.formCloseButton.UseVisualStyleBackColor = true;
            this.formCloseButton.Click += new System.EventHandler(this.formCloseButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 190);
            this.Controls.Add(this.formCloseButton);
            this.Controls.Add(this.showTailsButton);
            this.Controls.Add(this.showHeadsButton);
            this.Controls.Add(this.tailsPictureBox);
            this.Controls.Add(this.headsPictureBox);
            this.Name = "Form1";
            this.Text = "Heads or Tails";
            ((System.ComponentModel.ISupportInitialize)(this.headsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tailsPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox headsPictureBox;
        private System.Windows.Forms.PictureBox tailsPictureBox;
        private System.Windows.Forms.Button showHeadsButton;
        private System.Windows.Forms.Button showTailsButton;
        private System.Windows.Forms.Button formCloseButton;
    }
}

