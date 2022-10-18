namespace Book_Store.Interface.Book_Folder
{
    partial class Units_Nearing_Depletion
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
            this.ToClose_button3 = new System.Windows.Forms.Button();
            this.UnitsNearingDepletion_label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ToClose_button3
            // 
            this.ToClose_button3.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToClose_button3.Location = new System.Drawing.Point(12, 49);
            this.ToClose_button3.Name = "ToClose_button3";
            this.ToClose_button3.Size = new System.Drawing.Size(98, 34);
            this.ToClose_button3.TabIndex = 3;
            this.ToClose_button3.Text = "To Close";
            this.ToClose_button3.UseVisualStyleBackColor = true;
            this.ToClose_button3.Click += new System.EventHandler(this.ToClose_button3_Click);
            // 
            // UnitsNearingDepletion_label1
            // 
            this.UnitsNearingDepletion_label1.AutoSize = true;
            this.UnitsNearingDepletion_label1.Font = new System.Drawing.Font("Bell MT", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnitsNearingDepletion_label1.Location = new System.Drawing.Point(12, 9);
            this.UnitsNearingDepletion_label1.Name = "UnitsNearingDepletion_label1";
            this.UnitsNearingDepletion_label1.Size = new System.Drawing.Size(353, 37);
            this.UnitsNearingDepletion_label1.TabIndex = 2;
            this.UnitsNearingDepletion_label1.Text = "Units Nearing Depletion";
            // 
            // Units_Nearing_Depletion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 173);
            this.Controls.Add(this.ToClose_button3);
            this.Controls.Add(this.UnitsNearingDepletion_label1);
            this.Name = "Units_Nearing_Depletion";
            this.Text = "Units_Nearing_Depletion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ToClose_button3;
        private System.Windows.Forms.Label UnitsNearingDepletion_label1;
    }
}