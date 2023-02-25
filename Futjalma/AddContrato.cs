using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Futjalma
{
    public partial class AddContrato : Form
    {
        public AddContrato()
        {
            InitializeComponent();
        }

        private void contratacaoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.contratacaoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.futjalmaDataSet);

        }

        private void AddContrato_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'futjalmaDataSet.Contratacao'. Você pode movê-la ou removê-la conforme necessário.
            this.contratacaoTableAdapter.Fill(this.futjalmaDataSet.Contratacao);

        }

        private void btAddContrato_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void fechamentoDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void camisaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void clubeIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void jogadorIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
