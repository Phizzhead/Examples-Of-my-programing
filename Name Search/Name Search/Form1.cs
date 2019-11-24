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
using System.Security.Permissions;

namespace Name_Search
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {




            StreamReader inputBoysNameStream;
            StreamReader inputGirlsNameStream;

            const int numberOfNames = 200;

            int boysArrayIndex = 0;
            int girlsArrayIndex= 0;

            string[] boysNames = new string[numberOfNames];
            string[] girlsNames = new string[numberOfNames];

            inputBoysNameStream =  File.OpenText("BoyNames.txt");
            inputGirlsNameStream = File.OpenText("GirlNames.txt");
            
            while(boysArrayIndex < boysNames.Length && !inputBoysNameStream.EndOfStream)
            {
                boysNames[boysArrayIndex] = inputBoysNameStream.ReadLine();
                boysArrayIndex++;
            }

            while (girlsArrayIndex < girlsNames.Length && !inputGirlsNameStream.EndOfStream)
            {
                girlsNames[girlsArrayIndex] = inputGirlsNameStream.ReadLine();
                girlsArrayIndex++;
            }


            if(boysNameTextbox.Text != "")
            {
                if (boysNames.Contains(boysNameTextbox.Text))
                {
                    commonBoysNameDisplayLabel.Text = "Yes";
                }
                else
                {
                    commonBoysNameDisplayLabel.Text = "No";
                }
            }

            if(girlsNameTextbox.Text != "")
            {
                if (girlsNames.Contains(girlsNameTextbox.Text))
                {
                    commonGirlsNameDisplayLabel.Text = "Yes";
                }
                else
                {
                    commonGirlsNameDisplayLabel.Text = "No";
                }
            }

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            boysNameTextbox.Clear();
            girlsNameTextbox.Clear();
            commonGirlsNameDisplayLabel.ResetText();
            commonBoysNameDisplayLabel.ResetText();
            boysNameTextbox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
