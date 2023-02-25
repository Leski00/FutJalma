namespace Futjalma
{
    partial class AddPlayer
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
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label dataNascimentoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPlayer));
            System.Windows.Forms.Label iDLabel;
            this.lbAdd = new System.Windows.Forms.Label();
            this.btFechaAdd = new System.Windows.Forms.Button();
            this.futjalmaDataSet = new Futjalma.FutjalmaDataSet();
            this.jogadorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jogadorTableAdapter = new Futjalma.FutjalmaDataSetTableAdapters.JogadorTableAdapter();
            this.tableAdapterManager = new Futjalma.FutjalmaDataSetTableAdapters.TableAdapterManager();
            this.jogadorBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.jogadorBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tbNomeAdd = new System.Windows.Forms.TextBox();
            this.dataNascimentoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.jogadorDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            nomeLabel = new System.Windows.Forms.Label();
            dataNascimentoLabel = new System.Windows.Forms.Label();
            iDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.futjalmaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jogadorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jogadorBindingNavigator)).BeginInit();
            this.jogadorBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jogadorDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(13, 134);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(38, 13);
            nomeLabel.TabIndex = 12;
            nomeLabel.Text = "Nome:";
            // 
            // dataNascimentoLabel
            // 
            dataNascimentoLabel.AutoSize = true;
            dataNascimentoLabel.Location = new System.Drawing.Point(13, 182);
            dataNascimentoLabel.Name = "dataNascimentoLabel";
            dataNascimentoLabel.Size = new System.Drawing.Size(92, 13);
            dataNascimentoLabel.TabIndex = 14;
            dataNascimentoLabel.Text = "Data Nascimento:";
            // 
            // lbAdd
            // 
            this.lbAdd.AutoSize = true;
            this.lbAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAdd.Location = new System.Drawing.Point(12, 34);
            this.lbAdd.Name = "lbAdd";
            this.lbAdd.Size = new System.Drawing.Size(443, 24);
            this.lbAdd.TabIndex = 1;
            this.lbAdd.Text = "Coloque os dados do jogador para adicioná-lo";
            // 
            // btFechaAdd
            // 
            this.btFechaAdd.Location = new System.Drawing.Point(195, 475);
            this.btFechaAdd.Name = "btFechaAdd";
            this.btFechaAdd.Size = new System.Drawing.Size(75, 23);
            this.btFechaAdd.TabIndex = 9;
            this.btFechaAdd.Text = "FECHAR";
            this.btFechaAdd.UseVisualStyleBackColor = true;
            this.btFechaAdd.Click += new System.EventHandler(this.button2_Click);
            // 
            // futjalmaDataSet
            // 
            this.futjalmaDataSet.DataSetName = "FutjalmaDataSet";
            this.futjalmaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jogadorBindingSource
            // 
            this.jogadorBindingSource.DataMember = "Jogador";
            this.jogadorBindingSource.DataSource = this.futjalmaDataSet;
            // 
            // jogadorTableAdapter
            // 
            this.jogadorTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CampeonatoTableAdapter = null;
            this.tableAdapterManager.ClubeTableAdapter = null;
            this.tableAdapterManager.ContratacaoTableAdapter = null;
            this.tableAdapterManager.InscricaoTableAdapter = null;
            this.tableAdapterManager.JogadorTableAdapter = this.jogadorTableAdapter;
            this.tableAdapterManager.PartidaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Futjalma.FutjalmaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // jogadorBindingNavigator
            // 
            this.jogadorBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.jogadorBindingNavigator.BindingSource = this.jogadorBindingSource;
            this.jogadorBindingNavigator.CountItem = null;
            this.jogadorBindingNavigator.DeleteItem = null;
            this.jogadorBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.jogadorBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.jogadorBindingNavigatorSaveItem});
            this.jogadorBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.jogadorBindingNavigator.MoveFirstItem = null;
            this.jogadorBindingNavigator.MoveLastItem = null;
            this.jogadorBindingNavigator.MoveNextItem = null;
            this.jogadorBindingNavigator.MovePreviousItem = null;
            this.jogadorBindingNavigator.Name = "jogadorBindingNavigator";
            this.jogadorBindingNavigator.PositionItem = null;
            this.jogadorBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.jogadorBindingNavigator.Size = new System.Drawing.Size(548, 25);
            this.jogadorBindingNavigator.TabIndex = 10;
            this.jogadorBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.CheckOnClick = true;
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // jogadorBindingNavigatorSaveItem
            // 
            this.jogadorBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.jogadorBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("jogadorBindingNavigatorSaveItem.Image")));
            this.jogadorBindingNavigatorSaveItem.Name = "jogadorBindingNavigatorSaveItem";
            this.jogadorBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.jogadorBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.jogadorBindingNavigatorSaveItem.Click += new System.EventHandler(this.jogadorBindingNavigatorSaveItem_Click);
            // 
            // tbNomeAdd
            // 
            this.tbNomeAdd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jogadorBindingSource, "Nome", true));
            this.tbNomeAdd.Location = new System.Drawing.Point(111, 134);
            this.tbNomeAdd.Name = "tbNomeAdd";
            this.tbNomeAdd.Size = new System.Drawing.Size(231, 20);
            this.tbNomeAdd.TabIndex = 13;
            this.tbNomeAdd.TextChanged += new System.EventHandler(this.nomeTextBox_TextChanged);
            // 
            // dataNascimentoDateTimePicker
            // 
            this.dataNascimentoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.jogadorBindingSource, "DataNascimento", true));
            this.dataNascimentoDateTimePicker.Location = new System.Drawing.Point(111, 182);
            this.dataNascimentoDateTimePicker.Name = "dataNascimentoDateTimePicker";
            this.dataNascimentoDateTimePicker.Size = new System.Drawing.Size(231, 20);
            this.dataNascimentoDateTimePicker.TabIndex = 15;
            // 
            // jogadorDataGridView
            // 
            this.jogadorDataGridView.AutoGenerateColumns = false;
            this.jogadorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.jogadorDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewImageColumn1});
            this.jogadorDataGridView.DataSource = this.jogadorBindingSource;
            this.jogadorDataGridView.Location = new System.Drawing.Point(16, 249);
            this.jogadorDataGridView.Name = "jogadorDataGridView";
            this.jogadorDataGridView.Size = new System.Drawing.Size(439, 220);
            this.jogadorDataGridView.TabIndex = 15;
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DataNascimento";
            this.dataGridViewTextBoxColumn3.HeaderText = "DataNascimento";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "Foto";
            this.dataGridViewImageColumn1.HeaderText = "Foto";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(13, 98);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 15;
            iDLabel.Text = "ID:";
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jogadorBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(111, 91);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(35, 20);
            this.iDTextBox.TabIndex = 16;
            // 
            // AddPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 510);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(this.jogadorDataGridView);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.tbNomeAdd);
            this.Controls.Add(dataNascimentoLabel);
            this.Controls.Add(this.dataNascimentoDateTimePicker);
            this.Controls.Add(this.jogadorBindingNavigator);
            this.Controls.Add(this.btFechaAdd);
            this.Controls.Add(this.lbAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddPlayer";
            this.Text = "Adicione um jogador";
            this.Load += new System.EventHandler(this.AddPlayer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.futjalmaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jogadorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jogadorBindingNavigator)).EndInit();
            this.jogadorBindingNavigator.ResumeLayout(false);
            this.jogadorBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jogadorDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbAdd;
        private System.Windows.Forms.Button btFechaAdd;
        private FutjalmaDataSet futjalmaDataSet;
        private System.Windows.Forms.BindingSource jogadorBindingSource;
        private FutjalmaDataSetTableAdapters.JogadorTableAdapter jogadorTableAdapter;
        private FutjalmaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator jogadorBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton jogadorBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox tbNomeAdd;
        private System.Windows.Forms.DateTimePicker dataNascimentoDateTimePicker;
        private System.Windows.Forms.DataGridView jogadorDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.TextBox iDTextBox;
    }
}