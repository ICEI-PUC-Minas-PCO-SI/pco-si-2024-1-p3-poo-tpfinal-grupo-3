using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Cemig
{
    public partial class FormListaConsumidores : Form
    {
        public FormListaConsumidores()
        {
            InitializeComponent();
            LoadConsumerData();
        }

        private void LoadConsumerData()
        {
            var consumers = new List<Consumer>
            {
                new Consumer { Id = 1, Name = "João Silva", Email = "joao@example.com" },
                new Consumer { Id = 2, Name = "Maria Oliveira", Email = "maria@example.com" },
                new Consumer { Id = 3, Name = "Pedro Souza", Email = "pedro@example.com" },
            };

            dataGridViewConsumers.DataSource = consumers;
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            if (dataGridViewConsumers.SelectedRows.Count > 0)
            {
                int selectedId = (int)dataGridViewConsumers.SelectedRows[0].Cells[0].Value;
                MessageBox.Show($"Exibindo detalhes do consumidor com ID: {selectedId}");
            }
            else
            {
                MessageBox.Show("Por favor, selecione um consumidor na lista.");
            }
        }
    }

    public class Consumer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
