using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint_Job_Estimator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void caculateButton_Click(object sender, EventArgs e)
        {
            // declaration section 

            const double SQUARE_FEET_PER_GALLON = 115.0;
            // Square feet per labor hour is 115 / 8

            const double SQUARE_FEET_PER_LABOR_HOUR = 115.0 / 8.0;
            
            const decimal LABOR_PRICE_PER_HOUR = 20.00m;

            //text box values declaration and grabing input from boxes 
            try
            {
                decimal pricePerGallon = decimal.Parse(gallonsTextBox.Text);
                double squareFeet = double.Parse(squareFeetTextBox.Text);

                // caculation for gallons required and hours required
                double gallonsRequired = squareFeet / SQUARE_FEET_PER_GALLON;
                double laborHoursRequired = squareFeet / SQUARE_FEET_PER_LABOR_HOUR;

                // caculating cost
                decimal laborCost = (decimal)laborHoursRequired * LABOR_PRICE_PER_HOUR;
                decimal paintCost = (decimal)gallonsRequired * pricePerGallon;
                decimal totalCost = laborCost + paintCost;

                // displaying caculated values to label boxes
                displayGallonsRequired.Text = gallonsRequired.ToString();
                displayLaborHours.Text = laborHoursRequired.ToString();
                displayPaintCostLabel.Text = paintCost.ToString("C");
                displayLaborCostLabel.Text = laborCost.ToString("C");
                displayTotalCostLabel.Text = totalCost.ToString("C");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // setting all the input boxes and output boxes to an empty string
            gallonsTextBox.Text = "";
            squareFeetTextBox.Text = "";
            displayGallonsRequired.Text = "";
            displayLaborHours.Text = "";
            displayPaintCostLabel.Text = "";
            displayLaborCostLabel.Text = "";
            displayTotalCostLabel.Text = "";
            squareFeetTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
