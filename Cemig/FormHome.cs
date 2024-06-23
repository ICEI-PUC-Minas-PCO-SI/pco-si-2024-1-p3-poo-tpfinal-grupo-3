﻿using System;
using System.Windows.Forms;

namespace ConsumerApp
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void BtnAddAccount_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Adicionar Conta clicado!");
            // Lógica para adicionar conta
        }

        private void BtnRegisterConsumption_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Registrar Consumo clicado!");
            // Lógica para registrar consumo
        }

        private void BtnConsultAccounts_Click(object sender, EventArgs e)
        {
            FormsConsultaConta formConsultaConta = new FormsConsultaConta();
            formConsultaConta.Show();
        }
    }
}
