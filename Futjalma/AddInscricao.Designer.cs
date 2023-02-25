namespace Futjalma
{
    partial class AddInscricao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddInscricao));
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label clubeIDLabel;
            System.Windows.Forms.Label campeonatoIDLabel;
            this.lbAddCamp = new System.Windows.Forms.Label();
            this.futjalmaDataSet = new Futjalma.FutjalmaDataSet();
            this.inscricaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inscricaoTableAdapter = new Futjalma.FutjalmaDataSetTableAdapters.InscricaoTableAdapter();
            this.tableAdapterManager = new Futjalma.FutjalmaDataSetTableAdapters.TableAdapterManager();
            this.inscricaoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.inscricaoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.inscricaoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.clubeIDTextBox = new System.Windows.Forms.TextBox();
            this.campeonatoIDTextBox = new System.Windows.Forms.TextBox();
            this.btAddInscricao = new System.Windows.Forms.Button();
            iDLabel = new System.Windows.Forms.Label();
            clubeIDLabel = new System.Windows.Forms.Label();
            campeonatoIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.futjalmaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inscricaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inscricaoBindingNavigator)).BeginInit();
            this.inscricaoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inscricaoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lbAddCamp
            // 
            this.lbAddCamp.AutoSize = true;
            this.lbAddCamp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddCamp.Location = new System.Drawing.Point(12, 39);
            this.lbAddCamp.Name = "lbAddCamp";
            this.lbAddCamp.Size = new System.Drawing.Size(423, 24);
            this.lbAddCamp.TabIndex = 14;
            this.lbAddCamp.Text = "Prencha os campos para realizar a inscrição";
            // 
            // futjalmaDataSet
            // 
            this.futjalmaDataSet.DataSetName = "FutjalmaDataSet";
            this.futjalmaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inscricaoBindingSource
            // 
            this.inscricaoBindingSource.DataMember = "Inscricao";
            this.inscricaoBindingSource.DataSource = this.futjalmaDataSet;
            // 
            // inscricaoTableAdapter
            // 
            this.inscricaoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CampeonatoTableAdapter = null;
            this.tableAdapterManager.ClubeTableAdapter = null;
            this.tableAdapterManager.ContratacaoTableAdapter = null;
            this.tableAdapterManager.InscricaoTableAdapter = this.inscricaoTableAdapter;
            this.tableAdapterManager.JogadorTableAdapter = null;
            this.tableAdapterManager.PartidaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Futjalma.FutjalmaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // inscricaoBindingNavigator
            // 
            this.inscricaoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.inscricaoBindingNavigator.BindingSource = this.inscricaoBindingSource;
            this.inscricaoBindingNavigator.CountItem = null;
            this.inscricaoBindingNavigator.DeleteItem = null;
            this.inscricaoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.inscricaoBindingNavigatorSaveItem});
            this.inscricaoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.inscricaoBindingNavigator.MoveFirstItem = null;
            this.inscricaoBindingNavigator.MoveLastItem = null;
            this.inscricaoBindingNavigator.MoveNextItem = null;
            this.inscricaoBindingNavigator.MovePreviousItem = null;
            this.inscricaoBindingNavigator.Name = "inscricaoBindingNavigator";
            this.inscricaoBindingNavigator.PositionItem = null;
            this.inscricaoBindingNavigator.Size = new System.Drawing.Size(465, 25);
            this.inscricaoBindingNavigator.TabIndex = 15;
            this.inscricaoBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // inscricaoBindingNavigatorSaveItem
            // 
            this.inscricaoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.inscricaoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("inscricaoBindingNavigatorSaveItem.Image")));
            this.inscricaoBindingNavigatorSaveItem.Name = "inscricaoBindingNavigatorSaveItem";
            this.inscricaoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.inscricaoBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.inscricaoBindingNavigatorSaveItem.Click += new System.EventHandler(this.inscricaoBindingNavigatorSaveItem_Click);
            // 
            // inscricaoDataGridView
            // 
            this.inscricaoDataGridView.AutoGenerateColumns = false;
            this.inscricaoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inscricaoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.inscricaoDataGridView.DataSource = this.inscricaoBindingSource;
            this.inscricaoDataGridView.Location = new System.Drawing.Point(49, 203);
            this.inscricaoDataGridView.Name = "inscricaoDataGridView";
            this.inscricaoDataGridView.Size = new System.Drawing.Size(343, 268);
            this.inscricaoDataGridView.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ClubeID";
            this.dataGridViewTextBoxColumn2.HeaderText = "ClubeID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CampeonatoID";
            this.dataGridViewTextBoxColumn3.HeaderText = "CampeonatoID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(47, 84);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 15;
            iDLabel.Text = "ID:";
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inscricaoBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(137, 81);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(255, 20);
            this.iDTextBox.TabIndex = 16;
            // 
            // clubeIDLabel
            // 
            clubeIDLabel.AutoSize = true;
            clubeIDLabel.Location = new System.Drawing.Point(47, 110);
            clubeIDLabel.Name = "clubeIDLabel";
            clubeIDLabel.Size = new System.Drawing.Size(51, 13);
            clubeIDLabel.TabIndex = 17;
            clubeIDLabel.Text = "Clube ID:";
            // 
            // clubeIDTextBox
            // 
            this.clubeIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inscricaoBindingSource, "ClubeID", true));
            this.clubeIDTextBox.Location = new System.Drawing.Point(137, 107);
            this.clubeIDTextBox.Name = "clubeIDTextBox";
            this.clubeIDTextBox.Size = new System.Drawing.Size(255, 20);
            this.clubeIDTextBox.TabIndex = 18;
            // 
            // campeonatoIDLabel
            // 
            campeonatoIDLabel.AutoSize = true;
            campeonatoIDLabel.Location = new System.Drawing.Point(47, 136);
            campeonatoIDLabel.Name = "campeonatoIDLabel";
            campeonatoIDLabel.Size = new System.Drawing.Size(84, 13);
            campeonatoIDLabel.TabIndex = 19;
            campeonatoIDLabel.Text = "Campeonato ID:";
            // 
            // campeonatoIDTextBox
            // 
            this.campeonatoIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inscricaoBindingSource, "CampeonatoID", true));
            this.campeonatoIDTextBox.Location = new System.Drawing.Point(137, 133);
            this.campeonatoIDTextBox.Name = "campeonatoIDTextBox";
            this.campeonatoIDTextBox.Size = new System.Drawing.Size(255, 20);
            this.campeonatoIDTextBox.TabIndex = 20;
            // 
            // btAddInscricao
            // 
            this.btAddInscricao.Location = new System.Drawing.Point(378, 497);
            this.btAddInscricao.Name = "btAddInscricao";
            this.btAddInscricao.Size = new System.Drawing.Size(75, 23);
            this.btAddInscricao.TabIndex = 21;
            this.btAddInscricao.Text = "FECHAR";
            this.btAddInscricao.UseVisualStyleBackColor = true;
            this.btAddInscricao.Click += new System.EventHandler(this.btAddInscricao_Click);
            // 
            // AddInscricao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 536);
            this.Controls.Add(this.btAddInscricao);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(clubeIDLabel);
            this.Controls.Add(this.clubeIDTextBox);
            this.Controls.Add(campeonatoIDLabel);
            this.Controls.Add(this.campeonatoIDTextBox);
            this.Controls.Add(this.inscricaoDataGridView);
            this.Controls.Add(this.inscricaoBindingNavigator);
            this.Controls.Add(this.lbAddCamp);
            this.Name = "AddInscricao";
            this.Text = "AddInscricao";
            this.Load += new System.EventHandler(this.AddInscricao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.futjalmaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inscricaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inscricaoBindingNavigator)).EndInit();
            this.inscricaoBindingNavigator.ResumeLayout(false);
            this.inscricaoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inscricaoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbAddCamp;
        private FutjalmaDataSet futjalmaDataSet;
        private System.Windows.Forms.BindingSource inscricaoBindingSource;
        private FutjalmaDataSetTableAdapters.InscricaoTableAdapter inscricaoTableAdapter;
        private FutjalmaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator inscricaoBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton inscricaoBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView inscricaoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox clubeIDTextBox;
        private System.Windows.Forms.TextBox campeonatoIDTextBox;
        private System.Windows.Forms.Button btAddInscricao;
    }
}