﻿using Cemig.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cemig;

namespace Cemig
{
    public partial class FormRegistroEstatisticas : Form
    {

        private Usuario usuarioAtual;

        public FormRegistroEstatisticas(string usuarioLogadoCpfCnpj)
        {
            InitializeComponent();
            usuarioAtual = UtilitarioUsuario.CarregarUsuarioLogado(usuarioLogadoCpfCnpj);

        }

        private void FormRelatoriosEstatisticas_Load(object sender, EventArgs e)
        {
            cbPeriodo.Items.Add("Últimos 3 meses");
            cbPeriodo.Items.Add("Últimos 6 meses");
            cbPeriodo.Items.Add("Último ano");
            cbPeriodo.Items.Add("Personalizado");
            cbPeriodo.SelectedIndex = 0;

            dataGridViewConsumo.ColumnCount = 4;
            dataGridViewConsumo.Columns[0].Name = "Numero Registro";
            dataGridViewConsumo.Columns[1].Name = "Leitura Anterior";
            dataGridViewConsumo.Columns[2].Name = "Leitura Atual";
            dataGridViewConsumo.Columns[3].Name = "Consumo";
        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            dataGridViewConsumo.Rows.Clear();

            string periodoSelecionado = cbPeriodo.SelectedItem.ToString();

            List<Conta> contasFiltradas = new List<Conta>();

            if (periodoSelecionado == "Últimos 3 meses")
            {
                contasFiltradas = FiltrarContasPorPeriodo(3);
            }
            else if (periodoSelecionado == "Últimos 6 meses")
            {
                contasFiltradas = FiltrarContasPorPeriodo(6);
            }
            else if (periodoSelecionado == "Último ano")
            {
                contasFiltradas = FiltrarContasPorPeriodo(12);
            }

            foreach (var conta in contasFiltradas)
            {
                int consumo = conta.LeituraAtual - conta.LeituraAnterior;
                dataGridViewConsumo.Rows.Add(conta.NumeroDeRegistro, conta.LeituraAnterior, conta.LeituraAtual, consumo);
            }
        }


        private List<Conta> FiltrarContasPorPeriodo(int meses)
        {
            DateTime dataInicio = DateTime.Now.AddMonths(-meses);

            List<Conta> contasFiltradas = usuarioAtual.Contas
                .Where(c => c.DataLeitura >= dataInicio)
                .ToList();

            return contasFiltradas;
        }



        private void cbPeriodo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewConsumo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
