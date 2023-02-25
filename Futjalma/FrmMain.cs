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
    public partial class FrmMain : System.Windows.Forms.Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UcAddJogador component = new UcAddJogador();
            component.Dock = DockStyle.Fill;
            pnMain.Controls.Add(component);

            pnMain.Controls.Clear();

            AddPlayer addplayer = new AddPlayer();
            addplayer.Show();
            
        }

        private void atualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnMain.Controls.Clear();

            UcUpdateJogador component = new UcUpdateJogador();
            component.Dock = DockStyle.Fill;
            pnMain.Controls.Add(component);
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListPlayer listPlayer = new ListPlayer();
            listPlayer.Show();
            
        }

        private void listarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ListClube listclube = new ListClube();
            listclube.Show();
        }

        private void adicionarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddClube addClube = new AddClube();
            addClube.Show();
        }

      

        private void listarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ListCamp listCamp = new ListCamp();
            listCamp.Show();
        }

        private void adicionarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AddCamp addCamp = new AddCamp();   
            addCamp.Show();
        }

        private void listarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ListContrato listContrato = new ListContrato();
            listContrato.Show();
        }

        private void adicionarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            AddContrato addContrato = new AddContrato();    
            addContrato.Show();
        }

        private void listarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            ListInscricao listInscricao = new ListInscricao();
            listInscricao.Show();
        }

        private void adicionarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            AddInscricao addInscricao = new AddInscricao();
            addInscricao.Show();
        }

        private void jogosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listarToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            ListJogos listJogos = new ListJogos();
            listJogos.Show();
        }

        private void adicionarToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            AddJogos addJogos = new AddJogos(); 
            addJogos.Show();
        }
    }
}
