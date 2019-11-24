using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coin_Flip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showTailsButton_Click(object sender, EventArgs e)
        {
            tailsPictureBox.Visible = true;
            headsPictureBox.Visible = false;
        }

        private void showHeadsButton_Click(object sender, EventArgs e)
        {
            headsPictureBox.Visible = true;
            tailsPictureBox.Visible = false;
        }

        private void formCloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
