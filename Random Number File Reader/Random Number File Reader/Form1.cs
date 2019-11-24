using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Random_Number_File_Reader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void readFileButton_Click(object sender, EventArgs e)
        {
            int total= 0;
            int ammountOfNumbers= 0;
            StreamReader inputFile;
            try
            {
                if (openNumberFile.ShowDialog() == DialogResult.OK)
                {
                    inputFile = File.OpenText(openNumberFile.FileName);
                    while (!inputFile.EndOfStream)
                    {
                        int number;
                        number = int.Parse(inputFile.ReadLine());
                        numbersListBox.Items.Add(number);
                        total += number;
                        ++ammountOfNumbers;

                    }

                    numAmountDisplayLabel.Text = ammountOfNumbers.ToString();
                    totalDisplayBox.Text = total.ToString();
                    inputFile.Close();
                }
                else
                {
                    MessageBox.Show("file name not entered");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            numAmountDisplayLabel.Text = "";
            totalDisplayBox.Text = "";
            numbersListBox.Items.Clear();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
