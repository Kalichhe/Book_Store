namespace Book_Store.Interface.Guarantor_Folder
{
    partial class Pay_Off_Debt
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
            this.PayOffDebt_label1 = new System.Windows.Forms.Label();
            this.IdentificationCard_label1 = new System.Windows.Forms.Label();
            this.IdentificationCard_textBox1 = new System.Windows.Forms.TextBox();
            this.ToClose_button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cartBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PayOffDebt_label1
            // 
            this.PayOffDebt_label1.AutoSize = true;
            this.PayOffDebt_label1.Font = new System.Drawing.Font("Bell MT", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayOffDebt_label1.Location = new System.Drawing.Point(12, 9);
            this.PayOffDebt_label1.Name = "PayOffDebt_label1";
            this.PayOffDebt_label1.Size = new System.Drawing.Size(193, 37);
            this.PayOffDebt_label1.TabIndex = 3;
            this.PayOffDebt_label1.Text = "Pay Off Debt";
            // 
            // IdentificationCard_label1
            // 
            this.IdentificationCard_label1.AutoSize = true;
            this.IdentificationCard_label1.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdentificationCard_label1.Location = new System.Drawing.Point(12, 86);
            this.IdentificationCard_label1.Name = "IdentificationCard_label1";
            this.IdentificationCard_label1.Size = new System.Drawing.Size(169, 23);
            this.IdentificationCard_label1.TabIndex = 18;
            this.IdentificationCard_label1.Text = "Identification Card";
            // 
            // IdentificationCard_textBox1
            // 
            this.IdentificationCard_textBox1.Location = new System.Drawing.Point(324, 88);
            this.IdentificationCard_textBox1.Name = "IdentificationCard_textBox1";
            this.IdentificationCard_textBox1.Size = new System.Drawing.Size(259, 22);
            this.IdentificationCard_textBox1.TabIndex = 2;
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
            this.dataGridView1.DataSource = this.cartBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 112);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(571, 334);
            this.dataGridView1.TabIndex = 19;
            // 
            // cartBindingSource
            // 
            this.cartBindingSource.DataMember = "Cart";
            // 
            // Pay_Off_Debt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 458);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ToClose_button3);
            this.Controls.Add(this.IdentificationCard_label1);
            this.Controls.Add(this.IdentificationCard_textBox1);
            this.Controls.Add(this.PayOffDebt_label1);
            this.Name = "Pay_Off_Debt";
            this.Text = "Pay_Off_Debt";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PayOffDebt_label1;
        private System.Windows.Forms.Label IdentificationCard_label1;
        private System.Windows.Forms.TextBox IdentificationCard_textBox1;
        private System.Windows.Forms.Button ToClose_button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource cartBindingSource;
    }
}