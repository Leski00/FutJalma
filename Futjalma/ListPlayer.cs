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
    public partial class ListPlayer : System.Windows.Forms.Form
    {
        public ListPlayer()
        {
            InitializeComponent();
        }

        private void btFecharlista_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void jogadorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.jogadorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.futjalmaDataSet);

        }

        private void ListPlayer_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'futjalmaDataSet.Jogador'. Você pode movê-la ou removê-la conforme necessário.
            this.jogadorTableAdapter.Fill(this.futjalmaDataSet.Jogador);

        }
    }
}
