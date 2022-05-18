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
    public partial class Payingfrm : Form
    {
        private double tip;
        
        public Payingfrm()
        {
            InitializeComponent();
        }

        public Payingfrm(double tip)
        {
            InitializeComponent();
            this.tip = tip;
        }

        private void btnAddTip_Click(object sender, EventArgs e)
        {
            Tipfrm tf = new Tipfrm(5);
            this.Hide();
            tf.Closed += (s, args) => this.Close();
            tf.Show();
        }
    }
}
