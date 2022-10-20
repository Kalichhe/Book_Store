namespace Book_Store.Interface
{
    partial class Shopping_Cart
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
            this.ShoppingCart_label1 = new System.Windows.Forms.Label();
            this.ToClose_button3 = new System.Windows.Forms.Button();
            this.bookToCartBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetTotal = new Book_Store.DataSetTotal();
            this.shoppingCartBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetShoppingCart = new Book_Store.DB.DataSetShoppingCart();
            this.shoppingCartBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.shoppingCartTableAdapter = new Book_Store.DB.DataSetShoppingCartTableAdapters.ShoppingCartTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataSetBook_To_Cart = new Book_Store.DB.DataSetBook_To_Cart();
            this.dataSetBookToCartBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookToCartBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.book_To_CartTableAdapter = new Book_Store.DB.DataSetBook_To_CartTableAdapters.Book_To_CartTableAdapter();
            this.unitsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bookToCartBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoppingCartBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetShoppingCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoppingCartBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBook_To_Cart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBookToCartBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookToCartBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // ShoppingCart_label1
            // 
            this.ShoppingCart_label1.AutoSize = true;
            this.ShoppingCart_label1.Font = new System.Drawing.Font("Bell MT", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShoppingCart_label1.Location = new System.Drawing.Point(12, 9);
            this.ShoppingCart_label1.Name = "ShoppingCart_label1";
            this.ShoppingCart_label1.Size = new System.Drawing.Size(213, 37);
            this.ShoppingCart_label1.TabIndex = 0;
            this.ShoppingCart_label1.Text = "Shopping Cart";
            // 
            // ToClose_button3
            // 
            this.ToClose_button3.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToClose_button3.Location = new System.Drawing.Point(12, 50);
            this.ToClose_button3.Name = "ToClose_button3";
            this.ToClose_button3.Size = new System.Drawing.Size(98, 34);
            this.ToClose_button3.TabIndex = 16;
            this.ToClose_button3.Text = "To Close";
            this.ToClose_button3.UseVisualStyleBackColor = true;
            this.ToClose_button3.Click += new System.EventHandler(this.ToClose_button3_Click);
            // 
            // bookToCartBindingSource
            // 
            this.bookToCartBindingSource.DataMember = "Book_To_Cart";
            this.bookToCartBindingSource.DataSource = this.dataSetTotal;
            // 
            // dataSetTotal
            // 
            this.dataSetTotal.DataSetName = "DataSet1";
            this.dataSetTotal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // shoppingCartBindingSource
            // 
            this.shoppingCartBindingSource.DataMember = "Shopping_Cart";
            // 
            // dataSetShoppingCart
            // 
            this.dataSetShoppingCart.DataSetName = "DataSetShoppingCart";
            this.dataSetShoppingCart.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // shoppingCartBindingSource1
            // 
            this.shoppingCartBindingSource1.DataMember = "ShoppingCart";
            this.shoppingCartBindingSource1.DataSource = this.dataSetShoppingCart;
            // 
            // shoppingCartTableAdapter
            // 
            this.shoppingCartTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.unitsDataGridViewTextBoxColumn,
            this.codeDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.bookToCartBindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(12, 90);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(405, 348);
            this.dataGridView2.TabIndex = 18;
            // 
            // dataSetBook_To_Cart
            // 
            this.dataSetBook_To_Cart.DataSetName = "DataSetBook_To_Cart";
            this.dataSetBook_To_Cart.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSetBookToCartBindingSource
            // 
            this.dataSetBookToCartBindingSource.DataSource = this.dataSetBook_To_Cart;
            this.dataSetBookToCartBindingSource.Position = 0;
            // 
            // bookToCartBindingSource1
            // 
            this.bookToCartBindingSource1.DataMember = "Book_To_Cart";
            this.bookToCartBindingSource1.DataSource = this.dataSetBook_To_Cart;
            // 
            // book_To_CartTableAdapter
            // 
            this.book_To_CartTableAdapter.ClearBeforeFill = true;
            // 
            // unitsDataGridViewTextBoxColumn
            // 
            this.unitsDataGridViewTextBoxColumn.DataPropertyName = "Units";
            this.unitsDataGridViewTextBoxColumn.HeaderText = "Units";
            this.unitsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.unitsDataGridViewTextBoxColumn.Name = "unitsDataGridViewTextBoxColumn";
            this.unitsDataGridViewTextBoxColumn.Width = 125;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "Code";
            this.codeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.Width = 125;
            // 
            // Shopping_Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 450);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.ToClose_button3);
            this.Controls.Add(this.ShoppingCart_label1);
            this.Name = "Shopping_Cart";
            this.Text = "Shopping_Cart";
            this.Load += new System.EventHandler(this.Shopping_Cart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookToCartBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoppingCartBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetShoppingCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoppingCartBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBook_To_Cart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBookToCartBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookToCartBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ShoppingCart_label1;
        private System.Windows.Forms.Button ToClose_button3;
        private System.Windows.Forms.BindingSource shoppingCartBindingSource;
        private System.Windows.Forms.BindingSource bookToCartBindingSource;
        private DataSetTotal dataSetTotal;
        private DB.DataSetShoppingCart dataSetShoppingCart;
        private System.Windows.Forms.BindingSource shoppingCartBindingSource1;
        private DB.DataSetShoppingCartTableAdapters.ShoppingCartTableAdapter shoppingCartTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource dataSetBookToCartBindingSource;
        private DB.DataSetBook_To_Cart dataSetBook_To_Cart;
        private System.Windows.Forms.BindingSource bookToCartBindingSource1;
        private DB.DataSetBook_To_CartTableAdapters.Book_To_CartTableAdapter book_To_CartTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
    }
}