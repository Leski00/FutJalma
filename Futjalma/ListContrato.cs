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
    public partial class ListContrato : Form
    {
        public ListContrato()
        {
            InitializeComponent();
        }

        private void contratacaoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.contratacaoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.futjalmaDataSet);

        }

        private void ListContrato_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'futjalmaDataSet.Contratacao'. Você pode movê-la ou removê-la conforme necessário.
            this.contratacaoTableAdapter.Fill(this.futjalmaDataSet.Contratacao);

        }

        private void btListContrato_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
