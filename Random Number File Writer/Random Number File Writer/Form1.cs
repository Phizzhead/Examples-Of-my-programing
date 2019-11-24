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

namespace Random_Number_File_Writer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void writeFileButton_Click(object sender, EventArgs e)
        {
            // creating the file dialouge 
            try
            {
                int numbersToBeGenerated = int.Parse(randNumberAmmountTextBox.Text);

                SaveFileDialog randomNumberFileDialog = new SaveFileDialog();
                DialogResult fileOkCheck = randomNumberFileDialog.ShowDialog();
                

                StreamWriter outputFile;


                if (fileOkCheck == DialogResult.OK)
                {
                    outputFile = File.CreateText(randomNumberFileDialog.FileName);
                    for (int i = 1; i <= numbersToBeGenerated; ++i)
                    {
                        // keeps user from causing issues by hitting the open file button while application is running
                        writeFileButton.Visible = false;

                        //the tickcount + i allows the numbers to always have a diffrent  seed  without  using Sleep() which is unreliable  
                         
                        Random generatedNumber = new Random(Environment.TickCount + i);
                        outputFile.WriteLine(generatedNumber.Next(1, 101));
                        
                    }
                    outputFile.Close();
                    MessageBox.Show("File Succesfully Writen");
                    writeFileButton.Visible = true;
                }
                else
                {
                    MessageBox.Show("Invalid or nonexistent file save location.");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
