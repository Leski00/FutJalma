namespace Futjalma
{
    partial class ListContrato
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
            this.futjalmaDataSet = new Futjalma.FutjalmaDataSet();
            this.contratacaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contratacaoTableAdapter = new Futjalma.FutjalmaDataSetTableAdapters.ContratacaoTableAdapter();
            this.tableAdapterManager = new Futjalma.FutjalmaDataSetTableAdapters.TableAdapterManager();
            this.contratacaoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btListContrato = new System.Windows.Forms.Button();
            this.lbListContrato = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.futjalmaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratacaoBindingSource)).BeginInit();
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
            this.contratacaoDataGridView.Location = new System.Drawing.Point(12, 54);
            this.contratacaoDataGridView.Name = "contratacaoDataGridView";
            this.contratacaoDataGridView.Size = new System.Drawing.Size(543, 335);
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
            // btListContrato
            // 
            this.btListContrato.Location = new System.Drawing.Point(480, 415);
            this.btListContrato.Name = "btListContrato";
            this.btListContrato.Size = new System.Drawing.Size(75, 23);
            this.btListContrato.TabIndex = 2;
            this.btListContrato.Text = "FECHAR";
            this.btListContrato.UseVisualStyleBackColor = true;
            this.btListContrato.Click += new System.EventHandler(this.btListContrato_Click);
            // 
            // lbListContrato
            // 
            this.lbListContrato.AutoSize = true;
            this.lbListContrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbListContrato.Location = new System.Drawing.Point(12, 9);
            this.lbListContrato.Name = "lbListContrato";
            this.lbListContrato.Size = new System.Drawing.Size(176, 24);
            this.lbListContrato.TabIndex = 3;
            this.lbListContrato.Text = "Lista de Contratos";
            // 
            // ListContrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 450);
            this.Controls.Add(this.lbListContrato);
            this.Controls.Add(this.btListContrato);
            this.Controls.Add(this.contratacaoDataGridView);
            this.Name = "ListContrato";
            this.Text = "Lista de Contratos";
            this.Load += new System.EventHandler(this.ListContrato_Load);
            ((System.ComponentModel.ISupportInitialize)(this.futjalmaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratacaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratacaoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FutjalmaDataSet futjalmaDataSet;
        private System.Windows.Forms.BindingSource contratacaoBindingSource;
        private FutjalmaDataSetTableAdapters.ContratacaoTableAdapter contratacaoTableAdapter;
        private FutjalmaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView contratacaoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button btListContrato;
        private System.Windows.Forms.Label lbListContrato;
    }
}