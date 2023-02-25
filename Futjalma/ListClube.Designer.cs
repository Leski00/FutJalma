namespace Futjalma
{
    partial class ListClube
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
            this.lbClube = new System.Windows.Forms.Label();
            this.btFecharClube = new System.Windows.Forms.Button();
            this.futjalmaDataSet = new Futjalma.FutjalmaDataSet();
            this.clubeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clubeTableAdapter = new Futjalma.FutjalmaDataSetTableAdapters.ClubeTableAdapter();
            this.tableAdapterManager = new Futjalma.FutjalmaDataSetTableAdapters.TableAdapterManager();
            this.clubeDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.futjalmaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lbClube
            // 
            this.lbClube.AutoSize = true;
            this.lbClube.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClube.Location = new System.Drawing.Point(12, 9);
            this.lbClube.Name = "lbClube";
            this.lbClube.Size = new System.Drawing.Size(153, 24);
            this.lbClube.TabIndex = 1;
            this.lbClube.Text = "Lista de Clubes";
            // 
            // btFecharClube
            // 
            this.btFecharClube.Location = new System.Drawing.Point(380, 398);
            this.btFecharClube.Name = "btFecharClube";
            this.btFecharClube.Size = new System.Drawing.Size(75, 23);
            this.btFecharClube.TabIndex = 2;
            this.btFecharClube.Text = "FECHAR";
            this.btFecharClube.UseVisualStyleBackColor = true;
            this.btFecharClube.Click += new System.EventHandler(this.btFecharClube_Click);
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
            this.clubeDataGridView.Location = new System.Drawing.Point(12, 36);
            this.clubeDataGridView.Name = "clubeDataGridView";
            this.clubeDataGridView.Size = new System.Drawing.Size(443, 356);
            this.clubeDataGridView.TabIndex = 3;
            this.clubeDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clubeDataGridView_CellContentClick);
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
            // Listclube
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 456);
            this.Controls.Add(this.clubeDataGridView);
            this.Controls.Add(this.btFecharClube);
            this.Controls.Add(this.lbClube);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Listclube";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Listclube_Load);
            ((System.ComponentModel.ISupportInitialize)(this.futjalmaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubeDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbClube;
        private System.Windows.Forms.Button btFecharClube;
        private FutjalmaDataSet futjalmaDataSet;
        private System.Windows.Forms.BindingSource clubeBindingSource;
        private FutjalmaDataSetTableAdapters.ClubeTableAdapter clubeTableAdapter;
        private FutjalmaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView clubeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
    }
}