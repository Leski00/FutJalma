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
    public partial class AddPlayer : Form
    {
        public AddPlayer()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {

        }

        private void AddPlayer_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'futjalmaDataSet.Jogador'. Você pode movê-la ou removê-la conforme necessário.
            this.jogadorTableAdapter.Fill(this.futjalmaDataSet.Jogador);


        }

        private void lbFotoAdd_Click(object sender, EventArgs e)
        {

        }

        private void dtpDataAdd_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tbNomeAdd_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbNomeAdd_Click(object sender, EventArgs e)
        {

        }

        private void lbDataAdd_Click(object sender, EventArgs e)
        {

        }

        private void jogadorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.jogadorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.futjalmaDataSet);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            
        }

        private void nomeTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
