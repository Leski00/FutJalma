namespace Futjalma
{
    partial class AddClube
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddClube));
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label fundacaoLabel;
            this.lbAdd = new System.Windows.Forms.Label();
            this.btFechaAdd = new System.Windows.Forms.Button();
            this.futjalmaDataSet = new Futjalma.FutjalmaDataSet();
            this.clubeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clubeTableAdapter = new Futjalma.FutjalmaDataSetTableAdapters.ClubeTableAdapter();
            this.tableAdapterManager = new Futjalma.FutjalmaDataSetTableAdapters.TableAdapterManager();
            this.clubeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.clubeBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.fundacaoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.clubeDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            iDLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            fundacaoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.futjalmaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubeBindingNavigator)).BeginInit();
            this.clubeBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clubeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lbAdd
            // 
            this.lbAdd.AutoSize = true;
            this.lbAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAdd.Location = new System.Drawing.Point(12, 38);
            this.lbAdd.Name = "lbAdd";
            this.lbAdd.Size = new System.Drawing.Size(424, 24);
            this.lbAdd.TabIndex = 2;
            this.lbAdd.Text = "Coloque os dados do clube para adicioná-lo";
            // 
            // btFechaAdd
            // 
            this.btFechaAdd.Location = new System.Drawing.Point(392, 441);
            this.btFechaAdd.Name = "btFechaAdd";
            this.btFechaAdd.Size = new System.Drawing.Size(75, 23);
            this.btFechaAdd.TabIndex = 11;
            this.btFechaAdd.Text = "FECHAR";
            this.btFechaAdd.UseVisualStyleBackColor = true;
            this.btFechaAdd.Click += new System.EventHandler(this.btFechaAdd_Click);
            // 
            // futjalmaDataSet
            // 
            this.futjalmaDataSet.DataSetName = "FutjalmaDataSet";
            this.futjalmaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clubeBindingSource
            // 
            this.clubeBindingSource.DataMember = "Clube";
            this.clubeBindingSource.DataSource = this.futjalmaDataSet;
            // 
            // clubeTableAdapter
            // 
            this.clubeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CampeonatoTableAdapter = null;
            this.tableAdapterManager.ClubeTableAdapter = this.clubeTableAdapter;
            this.tableAdapterManager.ContratacaoTableAdapter = null;
            this.tableAdapterManager.InscricaoTableAdapter = null;
            this.tableAdapterManager.JogadorTableAdapter = null;
            this.tableAdapterManager.PartidaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Futjalma.FutjalmaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // clubeBindingNavigator
            // 
            this.clubeBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.clubeBindingNavigator.BindingSource = this.clubeBindingSource;
            this.clubeBindingNavigator.CountItem = null;
            this.clubeBindingNavigator.DeleteItem = null;
            this.clubeBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.clubeBindingNavigatorSaveItem});
            this.clubeBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.clubeBindingNavigator.MoveFirstItem = null;
            this.clubeBindingNavigator.MoveLastItem = null;
            this.clubeBindingNavigator.MoveNextItem = null;
            this.clubeBindingNavigator.MovePreviousItem = null;
            this.clubeBindingNavigator.Name = "clubeBindingNavigator";
            this.clubeBindingNavigator.PositionItem = null;
            this.clubeBindingNavigator.Size = new System.Drawing.Size(477, 25);
            this.clubeBindingNavigator.TabIndex = 12;
            this.clubeBindingNavigator.Text = "bindingNavigator1";
            this.clubeBindingNavigator.RefreshItems += new System.EventHandler(this.clubeBindingNavigator_RefreshItems);
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
            // clubeBindingNavigatorSaveItem
            // 
            this.clubeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.clubeBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("clubeBindingNavigatorSaveItem.Image")));
            this.clubeBindingNavigatorSaveItem.Name = "clubeBindingNavigatorSaveItem";
            this.clubeBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.clubeBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.clubeBindingNavigatorSaveItem.Click += new System.EventHandler(this.clubeBindingNavigatorSaveItem_Click_1);
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(18, 85);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 12;
            iDLabel.Text = "ID:";
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clubeBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(82, 82);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(200, 20);
            this.iDTextBox.TabIndex = 13;
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(18, 111);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(38, 13);
            nomeLabel.TabIndex = 14;
            nomeLabel.Text = "Nome:";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clubeBindingSource, "Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(82, 108);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(200, 20);
            this.nomeTextBox.TabIndex = 15;
            // 
            // fundacaoLabel
            // 
            fundacaoLabel.AutoSize = true;
            fundacaoLabel.Location = new System.Drawing.Point(18, 138);
            fundacaoLabel.Name = "fundacaoLabel";
            fundacaoLabel.Size = new System.Drawing.Size(58, 13);
            fundacaoLabel.TabIndex = 16;
            fundacaoLabel.Text = "Fundacao:";
            // 
            // fundacaoDateTimePicker
            // 
            this.fundacaoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.clubeBindingSource, "Fundacao", true));
            this.fundacaoDateTimePicker.Location = new System.Drawing.Point(82, 134);
            this.fundacaoDateTimePicker.Name = "fundacaoDateTimePicker";
            this.fundacaoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fundacaoDateTimePicker.TabIndex = 17;
            // 
            // clubeDataGridView
            // 
            this.clubeDataGridView.AutoGenerateColumns = false;
            this.clubeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clubeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewImageColumn1});
            this.clubeDataGridView.DataSource = this.clubeBindingSource;
            this.clubeDataGridView.Location = new System.Drawing.Point(21, 202);
            this.clubeDataGridView.Name = "clubeDataGridView";
            this.clubeDataGridView.Size = new System.Drawing.Size(446, 220);
            this.clubeDataGridView.TabIndex = 17;
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
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Fundacao";
            this.dataGridViewTextBoxColumn3.HeaderText = "Fundacao";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "Escudo";
            this.dataGridViewImageColumn1.HeaderText = "Escudo";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // AddClube
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 478);
            this.Controls.Add(this.clubeDataGridView);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(fundacaoLabel);
            this.Controls.Add(this.fundacaoDateTimePicker);
            this.Controls.Add(this.clubeBindingNavigator);
            this.Controls.Add(this.btFechaAdd);
            this.Controls.Add(this.lbAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddClube";
            this.Text = "Clube";
            this.Load += new System.EventHandler(this.AddClube_Load);
            ((System.ComponentModel.ISupportInitialize)(this.futjalmaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubeBindingNavigator)).EndInit();
            this.clubeBindingNavigator.ResumeLayout(false);
            this.clubeBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clubeDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbAdd;
        private System.Windows.Forms.Button btFechaAdd;
        private FutjalmaDataSet futjalmaDataSet;
        private System.Windows.Forms.BindingSource clubeBindingSource;
        private FutjalmaDataSetTableAdapters.ClubeTableAdapter clubeTableAdapter;
        private FutjalmaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator clubeBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton clubeBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.DateTimePicker fundacaoDateTimePicker;
        private System.Windows.Forms.DataGridView clubeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
    }
}