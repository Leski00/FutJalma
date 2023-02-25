
namespace Futjalma
{
    partial class FrmMain
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gerenciarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jogadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clubesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.campeonatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contratosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inscriçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jogosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.pnMain = new System.Windows.Forms.Panel();
            this.listarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.lbFutjalma = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.pnMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerenciarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(825, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gerenciarToolStripMenuItem
            // 
            this.gerenciarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jogadoresToolStripMenuItem,
            this.clubesToolStripMenuItem,
            this.campeonatosToolStripMenuItem,
            this.contratosToolStripMenuItem,
            this.inscriçõesToolStripMenuItem,
            this.jogosToolStripMenuItem});
            this.gerenciarToolStripMenuItem.Name = "gerenciarToolStripMenuItem";
            this.gerenciarToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.gerenciarToolStripMenuItem.Text = "Gerenciar";
            // 
            // jogadoresToolStripMenuItem
            // 
            this.jogadoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarToolStripMenuItem,
            this.adicionarToolStripMenuItem,
            this.atualizarToolStripMenuItem});
            this.jogadoresToolStripMenuItem.Name = "jogadoresToolStripMenuItem";
            this.jogadoresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.jogadoresToolStripMenuItem.Text = "Jogadores";
            // 
            // listarToolStripMenuItem
            // 
            this.listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            this.listarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listarToolStripMenuItem.Text = "Listar";
            this.listarToolStripMenuItem.Click += new System.EventHandler(this.listarToolStripMenuItem_Click);
            // 
            // adicionarToolStripMenuItem
            // 
            this.adicionarToolStripMenuItem.Name = "adicionarToolStripMenuItem";
            this.adicionarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.adicionarToolStripMenuItem.Text = "Adicionar";
            this.adicionarToolStripMenuItem.Click += new System.EventHandler(this.adicionarToolStripMenuItem_Click);
            // 
            // atualizarToolStripMenuItem
            // 
            this.atualizarToolStripMenuItem.Name = "atualizarToolStripMenuItem";
            this.atualizarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.atualizarToolStripMenuItem.Text = "Atualizar";
            this.atualizarToolStripMenuItem.Click += new System.EventHandler(this.atualizarToolStripMenuItem_Click);
            // 
            // clubesToolStripMenuItem
            // 
            this.clubesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarToolStripMenuItem1,
            this.adicionarToolStripMenuItem1});
            this.clubesToolStripMenuItem.Name = "clubesToolStripMenuItem";
            this.clubesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clubesToolStripMenuItem.Text = "Clubes";
            // 
            // listarToolStripMenuItem1
            // 
            this.listarToolStripMenuItem1.Name = "listarToolStripMenuItem1";
            this.listarToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.listarToolStripMenuItem1.Text = "Listar";
            this.listarToolStripMenuItem1.Click += new System.EventHandler(this.listarToolStripMenuItem1_Click);
            // 
            // adicionarToolStripMenuItem1
            // 
            this.adicionarToolStripMenuItem1.Name = "adicionarToolStripMenuItem1";
            this.adicionarToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.adicionarToolStripMenuItem1.Text = "Adicionar";
            this.adicionarToolStripMenuItem1.Click += new System.EventHandler(this.adicionarToolStripMenuItem1_Click);
            // 
            // campeonatosToolStripMenuItem
            // 
            this.campeonatosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarToolStripMenuItem2,
            this.adicionarToolStripMenuItem2});
            this.campeonatosToolStripMenuItem.Name = "campeonatosToolStripMenuItem";
            this.campeonatosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.campeonatosToolStripMenuItem.Text = "Campeonatos";
            // 
            // contratosToolStripMenuItem
            // 
            this.contratosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarToolStripMenuItem3,
            this.adicionarToolStripMenuItem3});
            this.contratosToolStripMenuItem.Name = "contratosToolStripMenuItem";
            this.contratosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.contratosToolStripMenuItem.Text = "Contratos";
            // 
            // inscriçõesToolStripMenuItem
            // 
            this.inscriçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarToolStripMenuItem4,
            this.adicionarToolStripMenuItem4});
            this.inscriçõesToolStripMenuItem.Name = "inscriçõesToolStripMenuItem";
            this.inscriçõesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.inscriçõesToolStripMenuItem.Text = "Inscrições";
            // 
            // jogosToolStripMenuItem
            // 
            this.jogosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarToolStripMenuItem5,
            this.adicionarToolStripMenuItem5});
            this.jogosToolStripMenuItem.Name = "jogosToolStripMenuItem";
            this.jogosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.jogosToolStripMenuItem.Text = "Jogos";
            this.jogosToolStripMenuItem.Click += new System.EventHandler(this.jogosToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 462);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(825, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // pnMain
            // 
            this.pnMain.Controls.Add(this.label1);
            this.pnMain.Controls.Add(this.lbFutjalma);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(0, 24);
            this.pnMain.Margin = new System.Windows.Forms.Padding(2);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(825, 438);
            this.pnMain.TabIndex = 2;
            // 
            // listarToolStripMenuItem2
            // 
            this.listarToolStripMenuItem2.Name = "listarToolStripMenuItem2";
            this.listarToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.listarToolStripMenuItem2.Text = "Listar";
            this.listarToolStripMenuItem2.Click += new System.EventHandler(this.listarToolStripMenuItem2_Click);
            // 
            // adicionarToolStripMenuItem2
            // 
            this.adicionarToolStripMenuItem2.Name = "adicionarToolStripMenuItem2";
            this.adicionarToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.adicionarToolStripMenuItem2.Text = "Adicionar";
            this.adicionarToolStripMenuItem2.Click += new System.EventHandler(this.adicionarToolStripMenuItem2_Click);
            // 
            // listarToolStripMenuItem3
            // 
            this.listarToolStripMenuItem3.Name = "listarToolStripMenuItem3";
            this.listarToolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.listarToolStripMenuItem3.Text = "Listar";
            this.listarToolStripMenuItem3.Click += new System.EventHandler(this.listarToolStripMenuItem3_Click);
            // 
            // adicionarToolStripMenuItem3
            // 
            this.adicionarToolStripMenuItem3.Name = "adicionarToolStripMenuItem3";
            this.adicionarToolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.adicionarToolStripMenuItem3.Text = "Adicionar";
            this.adicionarToolStripMenuItem3.Click += new System.EventHandler(this.adicionarToolStripMenuItem3_Click);
            // 
            // listarToolStripMenuItem4
            // 
            this.listarToolStripMenuItem4.Name = "listarToolStripMenuItem4";
            this.listarToolStripMenuItem4.Size = new System.Drawing.Size(180, 22);
            this.listarToolStripMenuItem4.Text = "Listar";
            this.listarToolStripMenuItem4.Click += new System.EventHandler(this.listarToolStripMenuItem4_Click);
            // 
            // adicionarToolStripMenuItem4
            // 
            this.adicionarToolStripMenuItem4.Name = "adicionarToolStripMenuItem4";
            this.adicionarToolStripMenuItem4.Size = new System.Drawing.Size(180, 22);
            this.adicionarToolStripMenuItem4.Text = "Adicionar";
            this.adicionarToolStripMenuItem4.Click += new System.EventHandler(this.adicionarToolStripMenuItem4_Click);
            // 
            // listarToolStripMenuItem5
            // 
            this.listarToolStripMenuItem5.Name = "listarToolStripMenuItem5";
            this.listarToolStripMenuItem5.Size = new System.Drawing.Size(180, 22);
            this.listarToolStripMenuItem5.Text = "Listar";
            this.listarToolStripMenuItem5.Click += new System.EventHandler(this.listarToolStripMenuItem5_Click);
            // 
            // adicionarToolStripMenuItem5
            // 
            this.adicionarToolStripMenuItem5.Name = "adicionarToolStripMenuItem5";
            this.adicionarToolStripMenuItem5.Size = new System.Drawing.Size(180, 22);
            this.adicionarToolStripMenuItem5.Text = "Adicionar";
            this.adicionarToolStripMenuItem5.Click += new System.EventHandler(this.adicionarToolStripMenuItem5_Click);
            // 
            // lbFutjalma
            // 
            this.lbFutjalma.AutoSize = true;
            this.lbFutjalma.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFutjalma.Location = new System.Drawing.Point(12, 20);
            this.lbFutjalma.Name = "lbFutjalma";
            this.lbFutjalma.Size = new System.Drawing.Size(91, 22);
            this.lbFutjalma.TabIndex = 0;
            this.lbFutjalma.Text = "ATENÇÃO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(736, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Para inserir algum dado ANTES de preencher  os campos  CLIQUE  no botão \"+\" amare" +
    "lo e a seguir preencha os campos.";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 484);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmMain";
            this.Text = "Futjalma";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnMain.ResumeLayout(false);
            this.pnMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.ToolStripMenuItem gerenciarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jogadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clubesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem campeonatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contratosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inscriçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jogosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem adicionarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem atualizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem adicionarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem adicionarToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem adicionarToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem adicionarToolStripMenuItem5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbFutjalma;
    }
}

