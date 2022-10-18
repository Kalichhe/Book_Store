namespace Book_Store.Interface.Book_Folder
{
    partial class Decrease_Book
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
            this.Send_button1 = new System.Windows.Forms.Button();
            this.UnitsToIncrease_textBox1 = new System.Windows.Forms.TextBox();
            this.UnitsToIncrease_label1 = new System.Windows.Forms.Label();
            this.BookCode_label1 = new System.Windows.Forms.Label();
            this.BookCode_textBox1 = new System.Windows.Forms.TextBox();
            this.ToClose_button3 = new System.Windows.Forms.Button();
            this.DecreaseBook_label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Send_button1
            // 
            this.Send_button1.Font = new System.Drawing.Font("Bell MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Send_button1.Location = new System.Drawing.Point(187, 146);
            this.Send_button1.Name = "Send_button1";
            this.Send_button1.Size = new System.Drawing.Size(86, 37);
            this.Send_button1.TabIndex = 4;
            this.Send_button1.Text = "Send";
            this.Send_button1.UseVisualStyleBackColor = true;
            this.Send_button1.Click += new System.EventHandler(this.Send_button1_Click);
            // 
            // UnitsToIncrease_textBox1
            // 
            this.UnitsToIncrease_textBox1.Location = new System.Drawing.Point(191, 118);
            this.UnitsToIncrease_textBox1.Name = "UnitsToIncrease_textBox1";
            this.UnitsToIncrease_textBox1.Size = new System.Drawing.Size(259, 22);
            this.UnitsToIncrease_textBox1.TabIndex = 3;
            // 
            // UnitsToIncrease_label1
            // 
            this.UnitsToIncrease_label1.AutoSize = true;
            this.UnitsToIncrease_label1.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnitsToIncrease_label1.Location = new System.Drawing.Point(12, 116);
            this.UnitsToIncrease_label1.Name = "UnitsToIncrease_label1";
            this.UnitsToIncrease_label1.Size = new System.Drawing.Size(166, 23);
            this.UnitsToIncrease_label1.TabIndex = 24;
            this.UnitsToIncrease_label1.Text = "Units To Decrease";
            // 
            // BookCode_label1
            // 
            this.BookCode_label1.AutoSize = true;
            this.BookCode_label1.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookCode_label1.Location = new System.Drawing.Point(12, 87);
            this.BookCode_label1.Name = "BookCode_label1";
            this.BookCode_label1.Size = new System.Drawing.Size(99, 23);
            this.BookCode_label1.TabIndex = 23;
            this.BookCode_label1.Text = "Book Code";
            // 
            // BookCode_textBox1
            // 
            this.BookCode_textBox1.Location = new System.Drawing.Point(191, 90);
            this.BookCode_textBox1.Name = "BookCode_textBox1";
            this.BookCode_textBox1.Size = new System.Drawing.Size(259, 22);
            this.BookCode_textBox1.TabIndex = 2;
            // 
            // ToClose_button3
            // 
            this.ToClose_button3.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToClose_button3.Location = new System.Drawing.Point(12, 50);
            this.ToClose_button3.Name = "ToClose_button3";
            this.ToClose_button3.Size = new System.Drawing.Size(98, 34);
            this.ToClose_button3.TabIndex = 1;
            this.ToClose_button3.Text = "To Close";
            this.ToClose_button3.UseVisualStyleBackColor = true;
            this.ToClose_button3.Click += new System.EventHandler(this.ToClose_button3_Click);
            // 
            // DecreaseBook_label1
            // 
            this.DecreaseBook_label1.AutoSize = true;
            this.DecreaseBook_label1.Font = new System.Drawing.Font("Bell MT", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DecreaseBook_label1.Location = new System.Drawing.Point(130, 10);
            this.DecreaseBook_label1.Name = "DecreaseBook_label1";
            this.DecreaseBook_label1.Size = new System.Drawing.Size(215, 37);
            this.DecreaseBook_label1.TabIndex = 19;
            this.DecreaseBook_label1.Text = "Decrease Book";
            // 
            // Decrease_Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 193);
            this.Controls.Add(this.Send_button1);
            this.Controls.Add(this.UnitsToIncrease_textBox1);
            this.Controls.Add(this.UnitsToIncrease_label1);
            this.Controls.Add(this.BookCode_label1);
            this.Controls.Add(this.BookCode_textBox1);
            this.Controls.Add(this.ToClose_button3);
            this.Controls.Add(this.DecreaseBook_label1);
            this.Name = "Decrease_Book";
            this.Text = "Decrease_Book";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Send_button1;
        private System.Windows.Forms.TextBox UnitsToIncrease_textBox1;
        private System.Windows.Forms.Label UnitsToIncrease_label1;
        private System.Windows.Forms.Label BookCode_label1;
        private System.Windows.Forms.TextBox BookCode_textBox1;
        private System.Windows.Forms.Button ToClose_button3;
        private System.Windows.Forms.Label DecreaseBook_label1;
    }
}