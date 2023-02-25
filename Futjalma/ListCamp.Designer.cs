namespace Futjalma
{
    partial class ListCamp
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
            this.lbListCamp = new System.Windows.Forms.Label();
            this.futjalmaDataSet = new Futjalma.FutjalmaDataSet();
            this.campeonatoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.campeonatoTableAdapter = new Futjalma.FutjalmaDataSetTableAdapters.CampeonatoTableAdapter();
            this.tableAdapterManager = new Futjalma.FutjalmaDataSetTableAdapters.TableAdapterManager();
            this.campeonatoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btListCamp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.futjalmaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.campeonatoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.campeonatoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lbListCamp
            // 
            this.lbListCamp.AutoSize = true;
            this.lbListCamp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbListCamp.Location = new System.Drawing.Point(8, 9);
            this.lbListCamp.Name = "lbListCamp";
            this.lbListCamp.Size = new System.Drawing.Size(216, 24);
            this.lbListCamp.TabIndex = 2;
            this.lbListCamp.Text = "Lista de Campeonatos";
            this.lbListCamp.Click += new System.EventHandler(this.lbClube_Click);
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
            this.campeonatoDataGridView.Location = new System.Drawing.Point(12, 36);
            this.campeonatoDataGridView.Name = "campeonatoDataGridView";
            this.campeonatoDataGridView.Size = new System.Drawing.Size(644, 402);
            this.campeonatoDataGridView.TabIndex = 3;
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
            // btListCamp
            // 
            this.btListCamp.Location = new System.Drawing.Point(565, 450);
            this.btListCamp.Name = "btListCamp";
            this.btListCamp.Size = new System.Drawing.Size(91, 23);
            this.btListCamp.TabIndex = 4;
            this.btListCamp.Text = "FECHAR";
            this.btListCamp.UseVisualStyleBackColor = true;
            // 
            // ListCamp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 485);
            this.Controls.Add(this.btListCamp);
            this.Controls.Add(this.campeonatoDataGridView);
            this.Controls.Add(this.lbListCamp);
            this.Name = "ListCamp";
            this.Text = "Lista de Campeonatos ";
            this.Load += new System.EventHandler(this.ListCamp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.futjalmaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.campeonatoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.campeonatoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbListCamp;
        private FutjalmaDataSet futjalmaDataSet;
        private System.Windows.Forms.BindingSource campeonatoBindingSource;
        private FutjalmaDataSetTableAdapters.CampeonatoTableAdapter campeonatoTableAdapter;
        private FutjalmaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView campeonatoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button btListCamp;
    }
}