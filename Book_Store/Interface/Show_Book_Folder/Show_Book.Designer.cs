namespace Book_Store.Interface.Show_Book_Folder
{
    partial class Show_Book
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
            this.ShowBook_label1 = new System.Windows.Forms.Label();
            this.ToClose_button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bookBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetBookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetBook = new Book_Store.DB.DataSetBook();
            this.bookBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.bookBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookTableAdapter = new Book_Store.DB.DataSetBookTableAdapters.BookTableAdapter();
            this.dataSetTotal = new Book_Store.DataSetTotal();
            this.bookBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetBookBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetBookBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBookBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBookBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // ShowBook_label1
            // 
            this.ShowBook_label1.AutoSize = true;
            this.ShowBook_label1.Font = new System.Drawing.Font("Bell MT", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowBook_label1.Location = new System.Drawing.Point(12, 9);
            this.ShowBook_label1.Name = "ShowBook_label1";
            this.ShowBook_label1.Size = new System.Drawing.Size(168, 37);
            this.ShowBook_label1.TabIndex = 1;
            this.ShowBook_label1.Text = "Show Book";
            // 
            // ToClose_button3
            // 
            this.ToClose_button3.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToClose_button3.Location = new System.Drawing.Point(12, 49);
            this.ToClose_button3.Name = "ToClose_button3";
            this.ToClose_button3.Size = new System.Drawing.Size(98, 34);
            this.ToClose_button3.TabIndex = 2;
            this.ToClose_button3.Text = "To Close";
            this.ToClose_button3.UseVisualStyleBackColor = true;
            this.ToClose_button3.Click += new System.EventHandler(this.ToClose_button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dataGridView1.DataSource = this.bookBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(12, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1071, 349);
            this.dataGridView1.TabIndex = 3;
            // 
            // bookBindingSource3
            // 
            this.bookBindingSource3.DataMember = "Book";
            this.bookBindingSource3.DataSource = this.dataSetBookBindingSource;
            // 
            // dataSetBookBindingSource
            // 
            this.dataSetBookBindingSource.DataSource = this.dataSetBook;
            this.dataSetBookBindingSource.Position = 0;
            // 
            // dataSetBook
            // 
            this.dataSetBook.DataSetName = "DataSetBook";
            this.dataSetBook.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookBindingSource2
            // 
            this.bookBindingSource2.DataMember = "Book";
            // 
            // bookBindingSource1
            // 
            this.bookBindingSource1.DataMember = "Book";
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataMember = "Book";
            // 
            // bookTableAdapter
            // 
            this.bookTableAdapter.ClearBeforeFill = true;
            // 
            // dataSetTotal
            // 
            this.dataSetTotal.DataSetName = "DataSet1";
            this.dataSetTotal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookBindingSource4
            // 
            this.bookBindingSource4.DataMember = "Book";
            this.bookBindingSource4.DataSource = this.dataSetTotal;
            // 
            // dataSetBookBindingSource1
            // 
            this.dataSetBookBindingSource1.DataSource = this.dataSetBook;
            this.dataSetBookBindingSource1.Position = 0;
            // 
            // dataSetBookBindingSource2
            // 
            this.dataSetBookBindingSource2.DataSource = this.dataSetBook;
            this.dataSetBookBindingSource2.Position = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Code";
            this.dataGridViewTextBoxColumn1.HeaderText = "Code";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Category";
            this.dataGridViewTextBoxColumn3.HeaderText = "Category";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Amount";
            this.dataGridViewTextBoxColumn4.HeaderText = "Amount";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Value";
            this.dataGridViewTextBoxColumn5.HeaderText = "Value";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // Show_Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ToClose_button3);
            this.Controls.Add(this.ShowBook_label1);
            this.Name = "Show_Book";
            this.Text = "Show_Book";
            this.Load += new System.EventHandler(this.Show_Book_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBookBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBookBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ShowBook_label1;
        private System.Windows.Forms.Button ToClose_button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private System.Windows.Forms.BindingSource bookBindingSource1;
        private System.Windows.Forms.BindingSource bookBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dataSetBookBindingSource;
        private DB.DataSetBook dataSetBook;
        private System.Windows.Forms.BindingSource bookBindingSource3;
        private DB.DataSetBookTableAdapters.BookTableAdapter bookTableAdapter;
        private System.Windows.Forms.BindingSource bookBindingSource4;
        private DataSetTotal dataSetTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.BindingSource dataSetBookBindingSource1;
        private System.Windows.Forms.BindingSource dataSetBookBindingSource2;
    }
}