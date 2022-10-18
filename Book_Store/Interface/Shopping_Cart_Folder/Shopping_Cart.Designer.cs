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
            this.ShoppingCart_label1 = new System.Windows.Forms.Label();
            this.ToClose_button3 = new System.Windows.Forms.Button();
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
            // Shopping_Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ToClose_button3);
            this.Controls.Add(this.ShoppingCart_label1);
            this.Name = "Shopping_Cart";
            this.Text = "Shopping_Cart";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ShoppingCart_label1;
        private System.Windows.Forms.Button ToClose_button3;
    }
}