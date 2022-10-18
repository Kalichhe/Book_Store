namespace Book_Store.Interface
{
    partial class Guarantor
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
            this.Guarantor_label1 = new System.Windows.Forms.Label();
            this.ToClose_button3 = new System.Windows.Forms.Button();
            this.AddGuarantor_button3 = new System.Windows.Forms.Button();
            this.ShowGuarantor_button3 = new System.Windows.Forms.Button();
            this.PayOffDebt_button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Guarantor_label1
            // 
            this.Guarantor_label1.AutoSize = true;
            this.Guarantor_label1.Font = new System.Drawing.Font("Bell MT", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guarantor_label1.Location = new System.Drawing.Point(119, 9);
            this.Guarantor_label1.Name = "Guarantor_label1";
            this.Guarantor_label1.Size = new System.Drawing.Size(158, 37);
            this.Guarantor_label1.TabIndex = 0;
            this.Guarantor_label1.Text = "Guarantor";
            // 
            // ToClose_button3
            // 
            this.ToClose_button3.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToClose_button3.Location = new System.Drawing.Point(12, 51);
            this.ToClose_button3.Name = "ToClose_button3";
            this.ToClose_button3.Size = new System.Drawing.Size(98, 34);
            this.ToClose_button3.TabIndex = 1;
            this.ToClose_button3.Text = "To Close";
            this.ToClose_button3.UseVisualStyleBackColor = true;
            this.ToClose_button3.Click += new System.EventHandler(this.ToClose_button3_Click);
            // 
            // AddGuarantor_button3
            // 
            this.AddGuarantor_button3.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddGuarantor_button3.Location = new System.Drawing.Point(12, 91);
            this.AddGuarantor_button3.Name = "AddGuarantor_button3";
            this.AddGuarantor_button3.Size = new System.Drawing.Size(172, 34);
            this.AddGuarantor_button3.TabIndex = 2;
            this.AddGuarantor_button3.Text = "Add Guarantor";
            this.AddGuarantor_button3.UseVisualStyleBackColor = true;
            this.AddGuarantor_button3.Click += new System.EventHandler(this.AddGuarantor_button3_Click);
            // 
            // ShowGuarantor_button3
            // 
            this.ShowGuarantor_button3.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowGuarantor_button3.Location = new System.Drawing.Point(12, 131);
            this.ShowGuarantor_button3.Name = "ShowGuarantor_button3";
            this.ShowGuarantor_button3.Size = new System.Drawing.Size(184, 34);
            this.ShowGuarantor_button3.TabIndex = 3;
            this.ShowGuarantor_button3.Text = "Show Guarantor";
            this.ShowGuarantor_button3.UseVisualStyleBackColor = true;
            this.ShowGuarantor_button3.Click += new System.EventHandler(this.ShowGuarantor_button3_Click);
            // 
            // PayOffDebt_button1
            // 
            this.PayOffDebt_button1.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayOffDebt_button1.Location = new System.Drawing.Point(12, 171);
            this.PayOffDebt_button1.Name = "PayOffDebt_button1";
            this.PayOffDebt_button1.Size = new System.Drawing.Size(153, 34);
            this.PayOffDebt_button1.TabIndex = 4;
            this.PayOffDebt_button1.Text = "Pay Off Debt";
            this.PayOffDebt_button1.UseVisualStyleBackColor = true;
            this.PayOffDebt_button1.Click += new System.EventHandler(this.PayOffDebt_button1_Click);
            // 
            // Guarantor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 223);
            this.Controls.Add(this.PayOffDebt_button1);
            this.Controls.Add(this.ShowGuarantor_button3);
            this.Controls.Add(this.AddGuarantor_button3);
            this.Controls.Add(this.ToClose_button3);
            this.Controls.Add(this.Guarantor_label1);
            this.Name = "Guarantor";
            this.Text = "Guarantor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Guarantor_label1;
        private System.Windows.Forms.Button ToClose_button3;
        private System.Windows.Forms.Button AddGuarantor_button3;
        private System.Windows.Forms.Button ShowGuarantor_button3;
        private System.Windows.Forms.Button PayOffDebt_button1;
    }
}