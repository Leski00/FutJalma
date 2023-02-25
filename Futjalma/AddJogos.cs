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
    public partial class AddJogos : Form
    {
        public AddJogos()
        {
            InitializeComponent();
        }

        private void partidaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.partidaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.futjalmaDataSet);

        }

        private void AddJogos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'futjalmaDataSet.Partida'. Você pode movê-la ou removê-la conforme necessário.
            this.partidaTableAdapter.Fill(this.futjalmaDataSet.Partida);

        }

        private void btAddJogos_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
