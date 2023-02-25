namespace Futjalma
{
    partial class AddCamp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCamp));
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label inicioLabel;
            System.Windows.Forms.Label premiacaoLabel;
            System.Windows.Forms.Label campeaoLabel;
            this.futjalmaDataSet = new Futjalma.FutjalmaDataSet();
            this.campeonatoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.campeonatoTableAdapter = new Futjalma.FutjalmaDataSetTableAdapters.CampeonatoTableAdapter();
            this.tableAdapterManager = new Futjalma.FutjalmaDataSetTableAdapters.TableAdapterManager();
            this.campeonatoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.campeonatoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.campeonatoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.inicioDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.premiacaoTextBox = new System.Windows.Forms.TextBox();
            this.campeaoTextBox = new System.Windows.Forms.TextBox();
            this.lbAddCamp = new System.Windows.Forms.Label();
            this.btAddCamp = new System.Windows.Forms.Button();
            iDLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            inicioLabel = new System.Windows.Forms.Label();
            premiacaoLabel = new System.Windows.Forms.Label();
            campeaoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.futjalmaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.campeonatoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.campeonatoBindingNavigator)).BeginInit();
            this.campeonatoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.campeonatoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // futjalmaDataSet
            // 
            this.futjalmaDataSet.DataSetName = "FutjalmaDataSet";
            this.futjalmaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // campeonatoBindingSource
            // 
            this.campeonatoBindingSource.DataMember = "Campeonato";
            this.campeonatoBindingSource.DataSource = this.futjalmaDataSet;
            // 
            // campeonatoTableAdapter
            // 
            this.campeonatoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CampeonatoTableAdapter = this.campeonatoTableAdapter;
            this.tableAdapterManager.ClubeTableAdapter = null;
            this.tableAdapterManager.ContratacaoTableAdapter = null;
            this.tableAdapterManager.InscricaoTableAdapter = null;
            this.tableAdapterManager.JogadorTableAdapter = null;
            this.tableAdapterManager.PartidaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Futjalma.FutjalmaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // campeonatoBindingNavigator
            // 
            this.campeonatoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.campeonatoBindingNavigator.BindingSource = this.campeonatoBindingSource;
            this.campeonatoBindingNavigator.CountItem = null;
            this.campeonatoBindingNavigator.DeleteItem = null;
            this.campeonatoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.campeonatoBindingNavigatorSaveItem});
            this.campeonatoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.campeonatoBindingNavigator.MoveFirstItem = null;
            this.campeonatoBindingNavigator.MoveLastItem = null;
            this.campeonatoBindingNavigator.MoveNextItem = null;
            this.campeonatoBindingNavigator.MovePreviousItem = null;
            this.campeonatoBindingNavigator.Name = "campeonatoBindingNavigator";
            this.campeonatoBindingNavigator.PositionItem = null;
            this.campeonatoBindingNavigator.Size = new System.Drawing.Size(667, 25);
            this.campeonatoBindingNavigator.TabIndex = 0;
            this.campeonatoBindingNavigator.Text = "bindingNavigator1";
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
            // campeonatoBindingNavigatorSaveItem
            // 
            this.campeonatoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.campeonatoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("campeonatoBindingNavigatorSaveItem.Image")));
            this.campeonatoBindingNavigatorSaveItem.Name = "campeonatoBindingNavigatorSaveItem";
            this.campeonatoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.campeonatoBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.campeonatoBindingNavigatorSaveItem.Click += new System.EventHandler(this.campeonatoBindingNavigatorSaveItem_Click);
            // 
            // campeonatoDataGridView
            // 
            this.campeonatoDataGridView.AutoGenerateColumns = false;
            this.campeonatoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.campeonatoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewImageColumn1,
            this.dataGridViewTextBoxColumn5});
            this.campeonatoDataGridView.DataSource = this.campeonatoBindingSource;
            this.campeonatoDataGridView.Location = new System.Drawing.Point(12, 239);
            this.campeonatoDataGridView.Name = "campeonatoDataGridView";
            this.campeonatoDataGridView.Size = new System.Drawing.Size(644, 254);
            this.campeonatoDataGridView.TabIndex = 1;
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
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Inicio";
            this.dataGridViewTextBoxColumn3.HeaderText = "Inicio";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Premiacao";
            this.dataGridViewTextBoxColumn4.HeaderText = "Premiacao";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "Logo";
            this.dataGridViewImageColumn1.HeaderText = "Logo";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Campeao";
            this.dataGridViewTextBoxColumn5.HeaderText = "Campeao";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(18, 91);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 2;
            iDLabel.Text = "ID:";
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.campeonatoBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(84, 88);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(405, 20);
            this.iDTextBox.TabIndex = 3;
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(18, 117);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(38, 13);
            nomeLabel.TabIndex = 4;
            nomeLabel.Text = "Nome:";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.campeonatoBindingSource, "Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(84, 114);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(405, 20);
            this.nomeTextBox.TabIndex = 5;
            // 
            // inicioLabel
            // 
            inicioLabel.AutoSize = true;
            inicioLabel.Location = new System.Drawing.Point(18, 144);
            inicioLabel.Name = "inicioLabel";
            inicioLabel.Size = new System.Drawing.Size(35, 13);
            inicioLabel.TabIndex = 6;
            inicioLabel.Text = "Inicio:";
            // 
            // inicioDateTimePicker
            // 
            this.inicioDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.campeonatoBindingSource, "Inicio", true));
            this.inicioDateTimePicker.Location = new System.Drawing.Point(84, 140);
            this.inicioDateTimePicker.Name = "inicioDateTimePicker";
            this.inicioDateTimePicker.Size = new System.Drawing.Size(405, 20);
            this.inicioDateTimePicker.TabIndex = 7;
            // 
            // premiacaoLabel
            // 
            premiacaoLabel.AutoSize = true;
            premiacaoLabel.Location = new System.Drawing.Point(18, 169);
            premiacaoLabel.Name = "premiacaoLabel";
            premiacaoLabel.Size = new System.Drawing.Size(60, 13);
            premiacaoLabel.TabIndex = 8;
            premiacaoLabel.Text = "Premiacao:";
            // 
            // premiacaoTextBox
            // 
            this.premiacaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.campeonatoBindingSource, "Premiacao", true));
            this.premiacaoTextBox.Location = new System.Drawing.Point(84, 166);
            this.premiacaoTextBox.Name = "premiacaoTextBox";
            this.premiacaoTextBox.Size = new System.Drawing.Size(405, 20);
            this.premiacaoTextBox.TabIndex = 9;
            // 
            // campeaoLabel
            // 
            campeaoLabel.AutoSize = true;
            campeaoLabel.Location = new System.Drawing.Point(18, 195);
            campeaoLabel.Name = "campeaoLabel";
            campeaoLabel.Size = new System.Drawing.Size(55, 13);
            campeaoLabel.TabIndex = 10;
            campeaoLabel.Text = "Campeao:";
            // 
            // campeaoTextBox
            // 
            this.campeaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.campeonatoBindingSource, "Campeao", true));
            this.campeaoTextBox.Location = new System.Drawing.Point(84, 192);
            this.campeaoTextBox.Name = "campeaoTextBox";
            this.campeaoTextBox.Size = new System.Drawing.Size(405, 20);
            this.campeaoTextBox.TabIndex = 11;
            // 
            // lbAddCamp
            // 
            this.lbAddCamp.AutoSize = true;
            this.lbAddCamp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddCamp.Location = new System.Drawing.Point(14, 44);
            this.lbAddCamp.Name = "lbAddCamp";
            this.lbAddCamp.Size = new System.Drawing.Size(487, 24);
            this.lbAddCamp.TabIndex = 12;
            this.lbAddCamp.Text = "Coloque os dados do campeoanto para adicioná-lo";
            // 
            // btAddCamp
            // 
            this.btAddCamp.Location = new System.Drawing.Point(580, 514);
            this.btAddCamp.Name = "btAddCamp";
            this.btAddCamp.Size = new System.Drawing.Size(75, 23);
            this.btAddCamp.TabIndex = 13;
            this.btAddCamp.Text = "FECHAR";
            this.btAddCamp.UseVisualStyleBackColor = true;
            this.btAddCamp.Click += new System.EventHandler(this.btAddCamp_Click);
            // 
            // AddCamp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 549);
            this.Controls.Add(this.btAddCamp);
            this.Controls.Add(this.lbAddCamp);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(inicioLabel);
            this.Controls.Add(this.inicioDateTimePicker);
            this.Controls.Add(premiacaoLabel);
            this.Controls.Add(this.premiacaoTextBox);
            this.Controls.Add(campeaoLabel);
            this.Controls.Add(this.campeaoTextBox);
            this.Controls.Add(this.campeonatoDataGridView);
            this.Controls.Add(this.campeonatoBindingNavigator);
            this.Name = "AddCamp";
            this.Text = "AddCamp";
            this.Load += new System.EventHandler(this.AddCamp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.futjalmaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.campeonatoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.campeonatoBindingNavigator)).EndInit();
            this.campeonatoBindingNavigator.ResumeLayout(false);
            this.campeonatoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.campeonatoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FutjalmaDataSet futjalmaDataSet;
        private System.Windows.Forms.BindingSource campeonatoBindingSource;
        private FutjalmaDataSetTableAdapters.CampeonatoTableAdapter campeonatoTableAdapter;
        private FutjalmaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator campeonatoBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton campeonatoBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView campeonatoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.DateTimePicker inicioDateTimePicker;
        private System.Windows.Forms.TextBox premiacaoTextBox;
        private System.Windows.Forms.TextBox campeaoTextBox;
        private System.Windows.Forms.Label lbAddCamp;
        private System.Windows.Forms.Button btAddCamp;
    }
}