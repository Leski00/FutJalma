namespace Futjalma
{
    partial class ListInscricao
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
            this.inscricaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inscricaoTableAdapter = new Futjalma.FutjalmaDataSetTableAdapters.InscricaoTableAdapter();
            this.tableAdapterManager = new Futjalma.FutjalmaDataSetTableAdapters.TableAdapterManager();
            this.inscricaoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbListInscricao = new System.Windows.Forms.Label();
            this.btListIncricao = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.futjalmaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inscricaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inscricaoDataGridView)).BeginInit();
            this.SuspendLayout();
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
            // inscricaoDataGridView
            // 
            this.inscricaoDataGridView.AutoGenerateColumns = false;
            this.inscricaoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inscricaoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.inscricaoDataGridView.DataSource = this.inscricaoBindingSource;
            this.inscricaoDataGridView.Location = new System.Drawing.Point(12, 55);
            this.inscricaoDataGridView.Name = "inscricaoDataGridView";
            this.inscricaoDataGridView.Size = new System.Drawing.Size(344, 348);
            this.inscricaoDataGridView.TabIndex = 1;
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
            // lbListInscricao
            // 
            this.lbListInscricao.AutoSize = true;
            this.lbListInscricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbListInscricao.Location = new System.Drawing.Point(12, 9);
            this.lbListInscricao.Name = "lbListInscricao";
            this.lbListInscricao.Size = new System.Drawing.Size(172, 24);
            this.lbListInscricao.TabIndex = 4;
            this.lbListInscricao.Text = "Lista de inscrição";
            // 
            // btListIncricao
            // 
            this.btListIncricao.Location = new System.Drawing.Point(280, 415);
            this.btListIncricao.Name = "btListIncricao";
            this.btListIncricao.Size = new System.Drawing.Size(75, 23);
            this.btListIncricao.TabIndex = 5;
            this.btListIncricao.Text = "FECHAR";
            this.btListIncricao.UseVisualStyleBackColor = true;
            this.btListIncricao.Click += new System.EventHandler(this.btListIncricao_Click);
            // 
            // ListInscricao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 450);
            this.Controls.Add(this.btListIncricao);
            this.Controls.Add(this.lbListInscricao);
            this.Controls.Add(this.inscricaoDataGridView);
            this.Name = "ListInscricao";
            this.Text = "Inscrições";
            this.Load += new System.EventHandler(this.ListInscricao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.futjalmaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inscricaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inscricaoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FutjalmaDataSet futjalmaDataSet;
        private System.Windows.Forms.BindingSource inscricaoBindingSource;
        private FutjalmaDataSetTableAdapters.InscricaoTableAdapter inscricaoTableAdapter;
        private FutjalmaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView inscricaoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label lbListInscricao;
        private System.Windows.Forms.Button btListIncricao;
    }
}