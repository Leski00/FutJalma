namespace Futjalma
{
    partial class AddJogos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddJogos));
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label campeonatoIDLabel;
            System.Windows.Forms.Label clube1IDLabel;
            System.Windows.Forms.Label clube2IDLabel;
            System.Windows.Forms.Label placar1Label;
            System.Windows.Forms.Label placar2Label;
            this.futjalmaDataSet = new Futjalma.FutjalmaDataSet();
            this.partidaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partidaTableAdapter = new Futjalma.FutjalmaDataSetTableAdapters.PartidaTableAdapter();
            this.tableAdapterManager = new Futjalma.FutjalmaDataSetTableAdapters.TableAdapterManager();
            this.partidaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.partidaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.campeonatoIDTextBox = new System.Windows.Forms.TextBox();
            this.clube1IDTextBox = new System.Windows.Forms.TextBox();
            this.clube2IDTextBox = new System.Windows.Forms.TextBox();
            this.placar1TextBox = new System.Windows.Forms.TextBox();
            this.placar2TextBox = new System.Windows.Forms.TextBox();
            this.partidaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbAddCamp = new System.Windows.Forms.Label();
            this.btAddJogos = new System.Windows.Forms.Button();
            iDLabel = new System.Windows.Forms.Label();
            campeonatoIDLabel = new System.Windows.Forms.Label();
            clube1IDLabel = new System.Windows.Forms.Label();
            clube2IDLabel = new System.Windows.Forms.Label();
            placar1Label = new System.Windows.Forms.Label();
            placar2Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.futjalmaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partidaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partidaBindingNavigator)).BeginInit();
            this.partidaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partidaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // futjalmaDataSet
            // 
            this.futjalmaDataSet.DataSetName = "FutjalmaDataSet";
            this.futjalmaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // partidaBindingSource
            // 
            this.partidaBindingSource.DataMember = "Partida";
            this.partidaBindingSource.DataSource = this.futjalmaDataSet;
            // 
            // partidaTableAdapter
            // 
            this.partidaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CampeonatoTableAdapter = null;
            this.tableAdapterManager.ClubeTableAdapter = null;
            this.tableAdapterManager.ContratacaoTableAdapter = null;
            this.tableAdapterManager.InscricaoTableAdapter = null;
            this.tableAdapterManager.JogadorTableAdapter = null;
            this.tableAdapterManager.PartidaTableAdapter = this.partidaTableAdapter;
            this.tableAdapterManager.UpdateOrder = Futjalma.FutjalmaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // partidaBindingNavigator
            // 
            this.partidaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.partidaBindingNavigator.BindingSource = this.partidaBindingSource;
            this.partidaBindingNavigator.CountItem = null;
            this.partidaBindingNavigator.DeleteItem = null;
            this.partidaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.partidaBindingNavigatorSaveItem});
            this.partidaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.partidaBindingNavigator.MoveFirstItem = null;
            this.partidaBindingNavigator.MoveLastItem = null;
            this.partidaBindingNavigator.MoveNextItem = null;
            this.partidaBindingNavigator.MovePreviousItem = null;
            this.partidaBindingNavigator.Name = "partidaBindingNavigator";
            this.partidaBindingNavigator.PositionItem = null;
            this.partidaBindingNavigator.Size = new System.Drawing.Size(669, 25);
            this.partidaBindingNavigator.TabIndex = 0;
            this.partidaBindingNavigator.Text = "bindingNavigator1";
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
            // partidaBindingNavigatorSaveItem
            // 
            this.partidaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.partidaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("partidaBindingNavigatorSaveItem.Image")));
            this.partidaBindingNavigatorSaveItem.Name = "partidaBindingNavigatorSaveItem";
            this.partidaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.partidaBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.partidaBindingNavigatorSaveItem.Click += new System.EventHandler(this.partidaBindingNavigatorSaveItem_Click);
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(168, 65);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 1;
            iDLabel.Text = "ID:";
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partidaBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(258, 62);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(218, 20);
            this.iDTextBox.TabIndex = 2;
            // 
            // campeonatoIDLabel
            // 
            campeonatoIDLabel.AutoSize = true;
            campeonatoIDLabel.Location = new System.Drawing.Point(168, 91);
            campeonatoIDLabel.Name = "campeonatoIDLabel";
            campeonatoIDLabel.Size = new System.Drawing.Size(84, 13);
            campeonatoIDLabel.TabIndex = 3;
            campeonatoIDLabel.Text = "Campeonato ID:";
            // 
            // campeonatoIDTextBox
            // 
            this.campeonatoIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partidaBindingSource, "CampeonatoID", true));
            this.campeonatoIDTextBox.Location = new System.Drawing.Point(258, 88);
            this.campeonatoIDTextBox.Name = "campeonatoIDTextBox";
            this.campeonatoIDTextBox.Size = new System.Drawing.Size(218, 20);
            this.campeonatoIDTextBox.TabIndex = 4;
            // 
            // clube1IDLabel
            // 
            clube1IDLabel.AutoSize = true;
            clube1IDLabel.Location = new System.Drawing.Point(168, 117);
            clube1IDLabel.Name = "clube1IDLabel";
            clube1IDLabel.Size = new System.Drawing.Size(54, 13);
            clube1IDLabel.TabIndex = 5;
            clube1IDLabel.Text = "Clube1ID:";
            // 
            // clube1IDTextBox
            // 
            this.clube1IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partidaBindingSource, "Clube1ID", true));
            this.clube1IDTextBox.Location = new System.Drawing.Point(258, 114);
            this.clube1IDTextBox.Name = "clube1IDTextBox";
            this.clube1IDTextBox.Size = new System.Drawing.Size(218, 20);
            this.clube1IDTextBox.TabIndex = 6;
            // 
            // clube2IDLabel
            // 
            clube2IDLabel.AutoSize = true;
            clube2IDLabel.Location = new System.Drawing.Point(168, 143);
            clube2IDLabel.Name = "clube2IDLabel";
            clube2IDLabel.Size = new System.Drawing.Size(54, 13);
            clube2IDLabel.TabIndex = 7;
            clube2IDLabel.Text = "Clube2ID:";
            // 
            // clube2IDTextBox
            // 
            this.clube2IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partidaBindingSource, "Clube2ID", true));
            this.clube2IDTextBox.Location = new System.Drawing.Point(258, 140);
            this.clube2IDTextBox.Name = "clube2IDTextBox";
            this.clube2IDTextBox.Size = new System.Drawing.Size(218, 20);
            this.clube2IDTextBox.TabIndex = 8;
            // 
            // placar1Label
            // 
            placar1Label.AutoSize = true;
            placar1Label.Location = new System.Drawing.Point(168, 169);
            placar1Label.Name = "placar1Label";
            placar1Label.Size = new System.Drawing.Size(46, 13);
            placar1Label.TabIndex = 9;
            placar1Label.Text = "Placar1:";
            // 
            // placar1TextBox
            // 
            this.placar1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partidaBindingSource, "Placar1", true));
            this.placar1TextBox.Location = new System.Drawing.Point(258, 166);
            this.placar1TextBox.Name = "placar1TextBox";
            this.placar1TextBox.Size = new System.Drawing.Size(218, 20);
            this.placar1TextBox.TabIndex = 10;
            // 
            // placar2Label
            // 
            placar2Label.AutoSize = true;
            placar2Label.Location = new System.Drawing.Point(168, 195);
            placar2Label.Name = "placar2Label";
            placar2Label.Size = new System.Drawing.Size(46, 13);
            placar2Label.TabIndex = 11;
            placar2Label.Text = "Placar2:";
            // 
            // placar2TextBox
            // 
            this.placar2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partidaBindingSource, "Placar2", true));
            this.placar2TextBox.Location = new System.Drawing.Point(258, 192);
            this.placar2TextBox.Name = "placar2TextBox";
            this.placar2TextBox.Size = new System.Drawing.Size(218, 20);
            this.placar2TextBox.TabIndex = 12;
            // 
            // partidaDataGridView
            // 
            this.partidaDataGridView.AutoGenerateColumns = false;
            this.partidaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partidaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.partidaDataGridView.DataSource = this.partidaBindingSource;
            this.partidaDataGridView.Location = new System.Drawing.Point(12, 237);
            this.partidaDataGridView.Name = "partidaDataGridView";
            this.partidaDataGridView.Size = new System.Drawing.Size(643, 220);
            this.partidaDataGridView.TabIndex = 13;
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CampeonatoID";
            this.dataGridViewTextBoxColumn2.HeaderText = "CampeonatoID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Clube1ID";
            this.dataGridViewTextBoxColumn3.HeaderText = "Clube1ID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Clube2ID";
            this.dataGridViewTextBoxColumn4.HeaderText = "Clube2ID";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Placar1";
            this.dataGridViewTextBoxColumn5.HeaderText = "Placar1";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Placar2";
            this.dataGridViewTextBoxColumn6.HeaderText = "Placar2";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // lbAddCamp
            // 
            this.lbAddCamp.AutoSize = true;
            this.lbAddCamp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddCamp.Location = new System.Drawing.Point(126, 25);
            this.lbAddCamp.Name = "lbAddCamp";
            this.lbAddCamp.Size = new System.Drawing.Size(423, 24);
            this.lbAddCamp.TabIndex = 15;
            this.lbAddCamp.Text = "Prencha os campos para realizar a inscrição";
            // 
            // btAddJogos
            // 
            this.btAddJogos.Location = new System.Drawing.Point(579, 474);
            this.btAddJogos.Name = "btAddJogos";
            this.btAddJogos.Size = new System.Drawing.Size(75, 23);
            this.btAddJogos.TabIndex = 16;
            this.btAddJogos.Text = "FECHAR";
            this.btAddJogos.UseVisualStyleBackColor = true;
            this.btAddJogos.Click += new System.EventHandler(this.btAddJogos_Click);
            // 
            // AddJogos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 509);
            this.Controls.Add(this.btAddJogos);
            this.Controls.Add(this.lbAddCamp);
            this.Controls.Add(this.partidaDataGridView);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(campeonatoIDLabel);
            this.Controls.Add(this.campeonatoIDTextBox);
            this.Controls.Add(clube1IDLabel);
            this.Controls.Add(this.clube1IDTextBox);
            this.Controls.Add(clube2IDLabel);
            this.Controls.Add(this.clube2IDTextBox);
            this.Controls.Add(placar1Label);
            this.Controls.Add(this.placar1TextBox);
            this.Controls.Add(placar2Label);
            this.Controls.Add(this.placar2TextBox);
            this.Controls.Add(this.partidaBindingNavigator);
            this.Name = "AddJogos";
            this.Text = "AddJogos";
            this.Load += new System.EventHandler(this.AddJogos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.futjalmaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partidaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partidaBindingNavigator)).EndInit();
            this.partidaBindingNavigator.ResumeLayout(false);
            this.partidaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partidaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FutjalmaDataSet futjalmaDataSet;
        private System.Windows.Forms.BindingSource partidaBindingSource;
        private FutjalmaDataSetTableAdapters.PartidaTableAdapter partidaTableAdapter;
        private FutjalmaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator partidaBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton partidaBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox campeonatoIDTextBox;
        private System.Windows.Forms.TextBox clube1IDTextBox;
        private System.Windows.Forms.TextBox clube2IDTextBox;
        private System.Windows.Forms.TextBox placar1TextBox;
        private System.Windows.Forms.TextBox placar2TextBox;
        private System.Windows.Forms.DataGridView partidaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Label lbAddCamp;
        private System.Windows.Forms.Button btAddJogos;
    }
}