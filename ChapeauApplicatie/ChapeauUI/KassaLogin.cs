using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapeauService;
using ChapeauModels;

namespace ChapeauUI
{
    public partial class KassaLogin : Form
    {
        public KassaLogin()
        {
            InitializeComponent();
        }

        private void btnKassaEnter_Click(object sender, EventArgs e)
        {
            //tijdelijk
            pnlKassaLogIn.Hide();

            EmployeeService employeeService = new EmployeeService();
            EmployeeModel employee = new EmployeeModel();

            employee.loginPassword = txtKassaLogIn.Text;
            string checkPassword = employee.loginPassword;
            bool employeeExist = employeeService.CheckEmployeeLogIn(checkPassword);

            if (employeeExist == true)
            {
                //kassa form
                pnlKassaLogIn.Hide();
            }
            else
            {
                MessageBox.Show($"Verkeerd wachtwoord, probeer het opnieuw!");
            }

        }

        private void btnKassa1_Click(object sender, EventArgs e)
        {

        }

        private void btnKassa2_Click(object sender, EventArgs e)
        {

        }

        private void btnKassa3_Click(object sender, EventArgs e)
        {

        }

        private void btnKassa4_Click(object sender, EventArgs e)
        {

        }

        private void btnKassa5_Click(object sender, EventArgs e)
        {

        }

        private void btnKassa6_Click(object sender, EventArgs e)
        {

        }

        private void btnKassa7_Click(object sender, EventArgs e)
        {

        }

        private void btnKassa8_Click(object sender, EventArgs e)
        {

        }

        private void btnKassa9_Click(object sender, EventArgs e)
        {

        }

        private void btnKassa0_Click(object sender, EventArgs e)
        {

        }

        private void btnKassaBack_Click(object sender, EventArgs e)
        {
            //delete latst ingetoetste nummer
        }

        private void btnKeukenOverzicht_Click(object sender, EventArgs e)
        {
            //form keuken overzicht laten zien
        }

        private void btnBarOverzicht_Click(object sender, EventArgs e)
        {
            //form bar overzicht laten zien
        }

        private void btnTafel1_Click(object sender, EventArgs e)
        {
            TablesService tablesService = new TablesService();
            int tafelNummer = 1;
            bool gereserveerd = tablesService.Reserved(tafelNummer);
            TafelStatus(gereserveerd);
        }
        public void TafelStatus(bool gereserveerd)
        {
            if (gereserveerd == true)
                lblViewStatus.Text = "Gereserveerd";
            else
                lblViewStatus.Text = "Vrij";
        }
    }
}
