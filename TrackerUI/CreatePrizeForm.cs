﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;

namespace TrackerUI
{
    public partial class CreatePrizeForm : Form
    {
        public CreatePrizeForm()
        {
            InitializeComponent();
        }

        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            if (validateForm())
            {
                PrizeModel model = new PrizeModel(
                    placeNameValue.Text, 
                    placeNumberValue.Text, 
                    prizeAmountValue.Text, 
                    prizePercentageValue.Text);

                foreach (IDataConnection db in GlobalConfig.Connections)
                {
                    db.CreatePrize(model);
                }
                placeNameValue.Text = "";
                placeNumberValue.Text = "";
                prizeAmountValue.Text = "0";
                prizePercentageValue.Text = "0";
            }
            else
            {
                MessageBox.Show("This form is invalid");
            }
        }
        private bool validateForm()
        {
            bool output = true;
            int placeNumber = 0;
            bool placeNumberValidNumber = int.TryParse(placeNumberValue.Text, out placeNumber);

            if (!placeNumberValidNumber || placeNumber < 1)
            {
                output = false;
            }

            if (placeNameLabel.Text.Length < 0)
            {
                output = false;
            }

            decimal prizeAmount = 0;
            double prizePercentage = 0;

            bool pizeAmountValid = decimal.TryParse(prizeAmountValue.Text, out prizeAmount);
            bool prizePercentageValid = double.TryParse(prizePercentageValue.Text, out prizePercentage);

            //if (pizeAmountValid == false && prizePercentageValid == false)
            //{
            //    output=false;
            //}


            if (pizeAmountValid && !prizePercentageValid)
            {
            //Use prize amount
            }
            if (!pizeAmountValid & prizePercentageValid)
            {
            //use prize percentage
            }


            if (prizeAmount <= 0 && prizePercentage < 0)
            {
                output = false;
            }

            if (prizePercentage < 0 && prizePercentage > 100)
            {
                output = false; 
            }


            return output;
        }
    }
}
