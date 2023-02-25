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
    public partial class ListClube : Form
    {
        public ListClube()
        {
            InitializeComponent();
        }

        private void btFecharClube_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void clubeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clubeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.futjalmaDataSet);

        }

        private void Listclube_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'futjalmaDataSet.Clube'. Você pode movê-la ou removê-la conforme necessário.
            this.clubeTableAdapter.Fill(this.futjalmaDataSet.Clube);

        }

        private void clubeDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
