﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChapeauUI.Forms
{
    public partial class Tipfrm : Form
    {
        const double TwoEuroTip = 2;
        const double FiveEuroTip = 5;
        const double TenEuroTip = 10;
        private double currentTotalAmount;

        public Tipfrm(double currentTotalAmount)
        {
            InitializeComponent();
            this.currentTotalAmount = currentTotalAmount;
            btnAddTip.Enabled = false;
        }

        // validate user entry for x euro and sends the tip to the paying form
        private void btnAddTip_Click(object sender, EventArgs e)
        {
            double tip = 0;
            
            // try to convert text to double and if it fails, show error message
            try
            {
                tip = Convert.ToDouble(txtbTip.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter a valid tip amount!\n" + ex , "Error!" );
                return;
            }

            
            if (tip > currentTotalAmount)
            {
                tip = tip - currentTotalAmount;
            } 
            
            if (validateUserEntry(tip))
            {
                OpenPayingFormWithTip(tip);
            }
        }

        // validate user entry for 2 euro and sends the tip to the paying form
        private void btnTwoEuro_Click(object sender, EventArgs e)
        {
            if (validateUserEntry(TwoEuroTip))
            {
                OpenPayingFormWithTip(TwoEuroTip);
            }
        }

        // validate user entry for 5 euro and sends the tip to the paying form
        private void btnFiveEuro_Click(object sender, EventArgs e)
        {
            if (validateUserEntry(FiveEuroTip))
            {
                OpenPayingFormWithTip(FiveEuroTip);
            }
        }

        // validate user entry for 10 euro and sends the tip to the paying form
        private void btnTenEuro_Click(object sender, EventArgs e)
        {
            if (validateUserEntry(TenEuroTip))
            {
                OpenPayingFormWithTip(TenEuroTip);
            }
        }

        // Validates if the user wants to add specific tip amount to the total check
        private bool validateUserEntry(double tip)
        {
            bool isValidated = false;
            DialogResult dialogResult = MessageBox.Show($"You are about to add €{tip} to the total are you sure?", "Warning!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                isValidated = true;
            }
            return isValidated;
        }

        // Opens the paying form with the tip amount
        private void OpenPayingFormWithTip(double tip)
        {
            Payingfrm pf = new Payingfrm(tip);
            this.Hide();
            pf.Closed += (s, args) => this.Close();
            pf.Show();
        }

        // Turns on the button when the textbox is not empty
        private void txtbTip_TextChanged(object sender, EventArgs e)
        {
            btnAddTip.Enabled = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Payingfrm pf = new Payingfrm();
            this.Hide();
            pf.Closed += (s, args) => this.Close();
            pf.Show();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            Payingfrm pf = new Payingfrm();
            this.Hide();
            pf.Closed += (s, args) => this.Close();
            pf.Show();
        }
    }
}
