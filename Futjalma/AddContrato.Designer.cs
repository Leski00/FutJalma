namespace Futjalma
{
    partial class AddContrato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddContrato));
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label jogadorIDLabel;
            System.Windows.Forms.Label clubeIDLabel;
            System.Windows.Forms.Label camisaLabel;
            System.Windows.Forms.Label fechamentoLabel;
            this.futjalmaDataSet = new Futjalma.FutjalmaDataSet();
            this.contratacaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contratacaoTableAdapter = new Futjalma.FutjalmaDataSetTableAdapters.ContratacaoTableAdapter();
            this.tableAdapterManager = new Futjalma.FutjalmaDataSetTableAdapters.TableAdapterManager();
            this.contratacaoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.contratacaoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.contratacaoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.jogadorIDTextBox = new System.Windows.Forms.TextBox();
            this.clubeIDTextBox = new System.Windows.Forms.TextBox();
            this.camisaTextBox = new System.Windows.Forms.TextBox();
            this.fechamentoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lbAddCamp = new System.Windows.Forms.Label();
            this.btAddContrato = new System.Windows.Forms.Button();
            iDLabel = new System.Windows.Forms.Label();
            jogadorIDLabel = new System.Windows.Forms.Label();
            clubeIDLabel = new System.Windows.Forms.Label();
            camisaLabel = new System.Windows.Forms.Label();
            fechamentoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.futjalmaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratacaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratacaoBindingNavigator)).BeginInit();
            this.contratacaoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contratacaoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // futjalmaDataSet
            // 
            this.futjalmaDataSet.DataSetName = "FutjalmaDataSet";
            this.futjalmaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contratacaoBindingSource
            // 
            this.contratacaoBindingSource.DataMember = "Contratacao";
            this.contratacaoBindingSource.DataSource = this.futjalmaDataSet;
            // 
            // contratacaoTableAdapter
            // 
            this.contratacaoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CampeonatoTableAdapter = null;
            this.tableAdapterManager.ClubeTableAdapter = null;
            this.tableAdapterManager.ContratacaoTableAdapter = this.contratacaoTableAdapter;
            this.tableAdapterManager.InscricaoTableAdapter = null;
            this.tableAdapterManager.JogadorTableAdapter = null;
            this.tableAdapterManager.PartidaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Futjalma.FutjalmaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // contratacaoBindingNavigator
            // 
            this.contratacaoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.contratacaoBindingNavigator.BindingSource = this.contratacaoBindingSource;
            this.contratacaoBindingNavigator.CountItem = null;
            this.contratacaoBindingNavigator.DeleteItem = null;
            this.contratacaoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.contratacaoBindingNavigatorSaveItem});
            this.contratacaoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.contratacaoBindingNavigator.MoveFirstItem = null;
            this.contratacaoBindingNavigator.MoveLastItem = null;
            this.contratacaoBindingNavigator.MoveNextItem = null;
            this.contratacaoBindingNavigator.MovePreviousItem = null;
            this.contratacaoBindingNavigator.Name = "contratacaoBindingNavigator";
            this.contratacaoBindingNavigator.PositionItem = null;
            this.contratacaoBindingNavigator.Size = new System.Drawing.Size(582, 25);
            this.contratacaoBindingNavigator.TabIndex = 0;
            this.contratacaoBindingNavigator.Text = "bindingNavigator1";
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
            // contratacaoBindingNavigatorSaveItem
            // 
            this.contratacaoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.contratacaoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("contratacaoBindingNavigatorSaveItem.Image")));
            this.contratacaoBindingNavigatorSaveItem.Name = "contratacaoBindingNavigatorSaveItem";
            this.contratacaoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.contratacaoBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.contratacaoBindingNavigatorSaveItem.Click += new System.EventHandler(this.contratacaoBindingNavigatorSaveItem_Click);
            // 
            // contratacaoDataGridView
            // 
            this.contratacaoDataGridView.AutoGenerateColumns = false;
            this.contratacaoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contratacaoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.contratacaoDataGridView.DataSource = this.contratacaoBindingSource;
            this.contratacaoDataGridView.Location = new System.Drawing.Point(19, 233);
            this.contratacaoDataGridView.Name = "contratacaoDataGridView";
            this.contratacaoDataGridView.Size = new System.Drawing.Size(545, 236);
            this.contratacaoDataGridView.TabIndex = 1;
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "JogadorID";
            this.dataGridViewTextBoxColumn2.HeaderText = "JogadorID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ClubeID";
            this.dataGridViewTextBoxColumn3.HeaderText = "ClubeID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Camisa";
            this.dataGridViewTextBoxColumn4.HeaderText = "Camisa";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Fechamento";
            this.dataGridViewTextBoxColumn5.HeaderText = "Fechamento";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(16, 78);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 2;
            iDLabel.Text = "ID:";
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contratacaoBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(91, 75);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(361, 20);
            this.iDTextBox.TabIndex = 3;
            // 
            // jogadorIDLabel
            // 
            jogadorIDLabel.AutoSize = true;
            jogadorIDLabel.Location = new System.Drawing.Point(16, 104);
            jogadorIDLabel.Name = "jogadorIDLabel";
            jogadorIDLabel.Size = new System.Drawing.Size(62, 13);
            jogadorIDLabel.TabIndex = 4;
            jogadorIDLabel.Text = "Jogador ID:";
            // 
            // jogadorIDTextBox
            // 
            this.jogadorIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contratacaoBindingSource, "JogadorID", true));
            this.jogadorIDTextBox.Location = new System.Drawing.Point(91, 101);
            this.jogadorIDTextBox.Name = "jogadorIDTextBox";
            this.jogadorIDTextBox.Size = new System.Drawing.Size(361, 20);
            this.jogadorIDTextBox.TabIndex = 5;
            this.jogadorIDTextBox.TextChanged += new System.EventHandler(this.jogadorIDTextBox_TextChanged);
            // 
            // clubeIDLabel
            // 
            clubeIDLabel.AutoSize = true;
            clubeIDLabel.Location = new System.Drawing.Point(16, 130);
            clubeIDLabel.Name = "clubeIDLabel";
            clubeIDLabel.Size = new System.Drawing.Size(51, 13);
            clubeIDLabel.TabIndex = 6;
            clubeIDLabel.Text = "Clube ID:";
            // 
            // clubeIDTextBox
            // 
            this.clubeIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contratacaoBindingSource, "ClubeID", true));
            this.clubeIDTextBox.Location = new System.Drawing.Point(91, 127);
            this.clubeIDTextBox.Name = "clubeIDTextBox";
            this.clubeIDTextBox.Size = new System.Drawing.Size(361, 20);
            this.clubeIDTextBox.TabIndex = 7;
            this.clubeIDTextBox.TextChanged += new System.EventHandler(this.clubeIDTextBox_TextChanged);
            // 
            // camisaLabel
            // 
            camisaLabel.AutoSize = true;
            camisaLabel.Location = new System.Drawing.Point(16, 156);
            camisaLabel.Name = "camisaLabel";
            camisaLabel.Size = new System.Drawing.Size(44, 13);
            camisaLabel.TabIndex = 8;
            camisaLabel.Text = "Camisa:";
            // 
            // camisaTextBox
            // 
            this.camisaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contratacaoBindingSource, "Camisa", true));
            this.camisaTextBox.Location = new System.Drawing.Point(91, 153);
            this.camisaTextBox.Name = "camisaTextBox";
            this.camisaTextBox.Size = new System.Drawing.Size(361, 20);
            this.camisaTextBox.TabIndex = 9;
            this.camisaTextBox.TextChanged += new System.EventHandler(this.camisaTextBox_TextChanged);
            // 
            // fechamentoLabel
            // 
            fechamentoLabel.AutoSize = true;
            fechamentoLabel.Location = new System.Drawing.Point(16, 183);
            fechamentoLabel.Name = "fechamentoLabel";
            fechamentoLabel.Size = new System.Drawing.Size(69, 13);
            fechamentoLabel.TabIndex = 10;
            fechamentoLabel.Text = "Fechamento:";
            // 
            // fechamentoDateTimePicker
            // 
            this.fechamentoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.contratacaoBindingSource, "Fechamento", true));
            this.fechamentoDateTimePicker.Location = new System.Drawing.Point(91, 179);
            this.fechamentoDateTimePicker.Name = "fechamentoDateTimePicker";
            this.fechamentoDateTimePicker.Size = new System.Drawing.Size(361, 20);
            this.fechamentoDateTimePicker.TabIndex = 11;
            this.fechamentoDateTimePicker.ValueChanged += new System.EventHandler(this.fechamentoDateTimePicker_ValueChanged);
            // 
            // lbAddCamp
            // 
            this.lbAddCamp.AutoSize = true;
            this.lbAddCamp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddCamp.Location = new System.Drawing.Point(12, 39);
            this.lbAddCamp.Name = "lbAddCamp";
            this.lbAddCamp.Size = new System.Drawing.Size(447, 24);
            this.lbAddCamp.TabIndex = 13;
            this.lbAddCamp.Text = "Coloque os dados do contrato para adicioná-lo";
            // 
            // btAddContrato
            // 
            this.btAddContrato.Location = new System.Drawing.Point(488, 488);
            this.btAddContrato.Name = "btAddContrato";
            this.btAddContrato.Size = new System.Drawing.Size(75, 23);
            this.btAddContrato.TabIndex = 14;
            this.btAddContrato.Text = "FECHAR";
            this.btAddContrato.UseVisualStyleBackColor = true;
            this.btAddContrato.Click += new System.EventHandler(this.btAddContrato_Click);
            // 
            // AddContrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 533);
            this.Controls.Add(this.btAddContrato);
            this.Controls.Add(this.lbAddCamp);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(jogadorIDLabel);
            this.Controls.Add(this.jogadorIDTextBox);
            this.Controls.Add(clubeIDLabel);
            this.Controls.Add(this.clubeIDTextBox);
            this.Controls.Add(camisaLabel);
            this.Controls.Add(this.camisaTextBox);
            this.Controls.Add(fechamentoLabel);
            this.Controls.Add(this.fechamentoDateTimePicker);
            this.Controls.Add(this.contratacaoDataGridView);
            this.Controls.Add(this.contratacaoBindingNavigator);
            this.Name = "AddContrato";
            this.Text = "AddContrato";
            this.Load += new System.EventHandler(this.AddContrato_Load);
            ((System.ComponentModel.ISupportInitialize)(this.futjalmaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratacaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratacaoBindingNavigator)).EndInit();
            this.contratacaoBindingNavigator.ResumeLayout(false);
            this.contratacaoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contratacaoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FutjalmaDataSet futjalmaDataSet;
        private System.Windows.Forms.BindingSource contratacaoBindingSource;
        private FutjalmaDataSetTableAdapters.ContratacaoTableAdapter contratacaoTableAdapter;
        private FutjalmaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator contratacaoBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton contratacaoBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView contratacaoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox jogadorIDTextBox;
        private System.Windows.Forms.TextBox clubeIDTextBox;
        private System.Windows.Forms.TextBox camisaTextBox;
        private System.Windows.Forms.DateTimePicker fechamentoDateTimePicker;
        private System.Windows.Forms.Label lbAddCamp;
        private System.Windows.Forms.Button btAddContrato;
    }
}