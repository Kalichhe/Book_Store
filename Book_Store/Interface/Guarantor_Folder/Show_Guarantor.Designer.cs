namespace Book_Store.Interface.Guarantor_Folder
{
    partial class Show_Guarantor
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
            this.ShowGuarantor_label1 = new System.Windows.Forms.Label();
            this.dataSetBook1 = new Book_Store.DataSetBook();
            this.ToClose_button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.guarantorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetGuarantor = new Book_Store.DataSetGuarantor();
            this.guarantorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.guarantorTableAdapter = new Book_Store.DataSetGuarantorTableAdapters.GuarantorTableAdapter();
            this.cedulaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dabtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBook1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guarantorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetGuarantor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guarantorBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // ShowGuarantor_label1
            // 
            this.ShowGuarantor_label1.AutoSize = true;
            this.ShowGuarantor_label1.Font = new System.Drawing.Font("Bell MT", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowGuarantor_label1.Location = new System.Drawing.Point(12, 9);
            this.ShowGuarantor_label1.Name = "ShowGuarantor_label1";
            this.ShowGuarantor_label1.Size = new System.Drawing.Size(240, 37);
            this.ShowGuarantor_label1.TabIndex = 2;
            this.ShowGuarantor_label1.Text = "Show Guarantor";
            // 
            // dataSetBook1
            // 
            this.dataSetBook1.DataSetName = "DataSetBook";
            this.dataSetBook1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ToClose_button3
            // 
            this.ToClose_button3.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToClose_button3.Location = new System.Drawing.Point(12, 49);
            this.ToClose_button3.Name = "ToClose_button3";
            this.ToClose_button3.Size = new System.Drawing.Size(98, 34);
            this.ToClose_button3.TabIndex = 1;
            this.ToClose_button3.Text = "To Close";
            this.ToClose_button3.UseVisualStyleBackColor = true;
            this.ToClose_button3.Click += new System.EventHandler(this.ToClose_button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cedulaDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.dabtDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.guarantorBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(19, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(571, 349);
            this.dataGridView1.TabIndex = 3;
            // 
            // guarantorBindingSource
            // 
            this.guarantorBindingSource.DataMember = "Guarantor";
            // 
            // dataSetGuarantor
            // 
            this.dataSetGuarantor.DataSetName = "DataSetGuarantor";
            this.dataSetGuarantor.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // guarantorBindingSource1
            // 
            this.guarantorBindingSource1.DataMember = "Guarantor";
            this.guarantorBindingSource1.DataSource = this.dataSetGuarantor;
            // 
            // guarantorTableAdapter
            // 
            this.guarantorTableAdapter.ClearBeforeFill = true;
            // 
            // cedulaDataGridViewTextBoxColumn
            // 
            this.cedulaDataGridViewTextBoxColumn.DataPropertyName = "Cedula";
            this.cedulaDataGridViewTextBoxColumn.HeaderText = "Cedula";
            this.cedulaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cedulaDataGridViewTextBoxColumn.Name = "cedulaDataGridViewTextBoxColumn";
            this.cedulaDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // dabtDataGridViewTextBoxColumn
            // 
            this.dabtDataGridViewTextBoxColumn.DataPropertyName = "Dabt";
            this.dabtDataGridViewTextBoxColumn.HeaderText = "Dabt";
            this.dabtDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dabtDataGridViewTextBoxColumn.Name = "dabtDataGridViewTextBoxColumn";
            this.dabtDataGridViewTextBoxColumn.Width = 125;
            // 
            // Show_Guarantor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ToClose_button3);
            this.Controls.Add(this.ShowGuarantor_label1);
            this.Name = "Show_Guarantor";
            this.Text = "Show_Guarantor";
            this.Load += new System.EventHandler(this.Show_Guarantor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBook1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guarantorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetGuarantor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guarantorBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ShowGuarantor_label1;
        private DataSetBook dataSetBook1;
        private System.Windows.Forms.Button ToClose_button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource guarantorBindingSource;
        private DataSetGuarantor dataSetGuarantor;
        private System.Windows.Forms.BindingSource guarantorBindingSource1;
        private DataSetGuarantorTableAdapters.GuarantorTableAdapter guarantorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedulaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dabtDataGridViewTextBoxColumn;
    }
}