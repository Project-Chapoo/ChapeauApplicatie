﻿using System;
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
            EmployeeService employeeService = new EmployeeService();
            EmployeeModel employee = new EmployeeModel();

            employee.loginPassword = txtKassaLogIn.Text;
            string employeeExist = employeeService.CheckEmployeeLogIn(employee.loginPassword);

            if (employeeExist == "Wrong password")
            {
                MessageBox.Show($"Verkeerd wachtwoord, probeer het opnieuw!");
                txtKassaLogIn.Clear();
            }
            else
            {
                TafelOverzicht tafelOverzicht = new TafelOverzicht();
                this.Hide();
                tafelOverzicht.Closed += (s, args) => this.Close();
                tafelOverzicht.Show();
            }
        }
        private void btnKassa1_Click(object sender, EventArgs e)
        {
            if(txtKassaLogIn.TextLength < 4)
                txtKassaLogIn.Text += 1;
        }
        private void btnKassa2_Click(object sender, EventArgs e)
        {
            if (txtKassaLogIn.TextLength < 4)
                txtKassaLogIn.Text += 2;
        }
        private void btnKassa3_Click(object sender, EventArgs e)
        {
            if (txtKassaLogIn.TextLength < 4)
                txtKassaLogIn.Text += 3;
        }
        private void btnKassa4_Click(object sender, EventArgs e)
        {
            if (txtKassaLogIn.TextLength < 4)
                txtKassaLogIn.Text += 4;
        }
        private void btnKassa5_Click(object sender, EventArgs e)
        {
            if (txtKassaLogIn.TextLength < 4)
                txtKassaLogIn.Text += 5;
        }
        private void btnKassa6_Click(object sender, EventArgs e)
        {
            if (txtKassaLogIn.TextLength < 4)
                txtKassaLogIn.Text += 6;
        }
        private void btnKassa7_Click(object sender, EventArgs e)
        {
            if (txtKassaLogIn.TextLength < 4)
                txtKassaLogIn.Text += 7;
        }
        private void btnKassa8_Click(object sender, EventArgs e)
        {
            if (txtKassaLogIn.TextLength < 4)
                txtKassaLogIn.Text += 8;
        }
        private void btnKassa9_Click(object sender, EventArgs e)
        {
            if (txtKassaLogIn.TextLength < 4)
                txtKassaLogIn.Text += 9;
        }
        private void btnKassa0_Click(object sender, EventArgs e)
        {
            if (txtKassaLogIn.TextLength < 4)
                txtKassaLogIn.Text += 0;
        }
        private void btnKassaBack_Click(object sender, EventArgs e)
        {
            //delete laatst ingetoetste nummer
            txtKassaLogIn.Text = txtKassaLogIn.Text.Substring(0, txtKassaLogIn.TextLength - 1);
        }
        //count voor het heen en weer klikken
        public int count = 0;
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            count++;
            if (count % 2 != 0)
                txtKassaLogIn.UseSystemPasswordChar = false;
            else
                txtKassaLogIn.UseSystemPasswordChar = true;
        }
        //Timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime KassaTijd = DateTime.Now;
            KassaInlogTijd.Text = KassaTijd.ToString("HH:mm  dd-MM-yyyy");
        }
        private void KassaLogin_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void panelTafelOverzicht_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
