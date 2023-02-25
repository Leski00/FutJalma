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
    public partial class AddClube : Form
    {
        public AddClube()
        {
            InitializeComponent();
        }

        private void btFechaAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    using(var entities = new FutjalmaEntities1())
            //    {
            //        Clube Clubes = new Clube();
            //        Clubes.Nome = tbNomeAdd.Text;
            //        Clubes.Fundacao = dtpDataAdd.Value;
            //        //Clube.Foto
                   
            //    }
               
            //}
            //catch
            //{

            //}
        }

        private void clubeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clubeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.futjalmaDataSet);

        }

        private void AddClube_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'futjalmaDataSet.Clube'. Você pode movê-la ou removê-la conforme necessário.
            this.clubeTableAdapter.Fill(this.futjalmaDataSet.Clube);
            // TODO: esta linha de código carrega dados na tabela 'futjalmaDataSet.Clube'. Você pode movê-la ou removê-la conforme necessário.
            this.clubeTableAdapter.Fill(this.futjalmaDataSet.Clube);

        }

        private void clubeBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.clubeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.futjalmaDataSet);

        }

        private void clubeBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}
