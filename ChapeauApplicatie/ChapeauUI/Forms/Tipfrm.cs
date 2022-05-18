using System;
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
        }

        private void btnAddTip_Click(object sender, EventArgs e)
        {
            double tip = Convert.ToDouble(txtbTip.Text);
            
            if (tip > currentTotalAmount)
            {
                tip = tip - currentTotalAmount;
            } 
            
            if (validateUserEntry(tip))
            {
                OpenPayingFormWithTip(tip);
            }
        }

        private void btnTwoEuro_Click(object sender, EventArgs e)
        {
            if (validateUserEntry(TwoEuroTip))
            {
                OpenPayingFormWithTip(TwoEuroTip);
            }
        }

        private void btnFiveEuro_Click(object sender, EventArgs e)
        {
            if (validateUserEntry(FiveEuroTip))
            {
                OpenPayingFormWithTip(FiveEuroTip);
            }
        }
        
        private void btnTenEuro_Click(object sender, EventArgs e)
        {
            if (validateUserEntry(TenEuroTip))
            {
                OpenPayingFormWithTip(TenEuroTip);
            }
        }
        
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
        private void OpenPayingFormWithTip(double tip)
        {
            Payingfrm pf = new Payingfrm(tip);
            this.Close();
        }
    }
}
