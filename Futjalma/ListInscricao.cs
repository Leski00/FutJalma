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
    public partial class ListInscricao : Form
    {
        public ListInscricao()
        {
            InitializeComponent();
        }

        private void inscricaoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.inscricaoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.futjalmaDataSet);

        }

        private void ListInscricao_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'futjalmaDataSet.Inscricao'. Você pode movê-la ou removê-la conforme necessário.
            this.inscricaoTableAdapter.Fill(this.futjalmaDataSet.Inscricao);

        }

        private void btListIncricao_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
