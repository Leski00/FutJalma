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
    public partial class ListCamp : Form
    {
        public ListCamp()
        {
            InitializeComponent();
        }

        private void campeonatoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.campeonatoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.futjalmaDataSet);

        }

        private void ListCamp_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'futjalmaDataSet.Campeonato'. Você pode movê-la ou removê-la conforme necessário.
            this.campeonatoTableAdapter.Fill(this.futjalmaDataSet.Campeonato);

        }

        private void lbClube_Click(object sender, EventArgs e)
        {

        }
    }
}
