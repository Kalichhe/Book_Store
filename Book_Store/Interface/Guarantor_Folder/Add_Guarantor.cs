using Book_Store.CRUD.Add_Book;
using Book_Store.CRUD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Book_Store.Guarantor.Guarantor_1;

namespace Book_Store.Interface.Guarantor_Folder
{
    public partial class Add_Guarantor : Form
    {
        public Add_Guarantor()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void ToClose_button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Send_button1_Click(object sender, EventArgs e)
        {
            if (IdentificationCard_textBox1.Text.Trim() == "")
            {
                MessageBox.Show("ENTER AN ID");
            }
            else if (Name_textBox1.Text.Trim() == "")
            {
                MessageBox.Show("ENTER A NAME");
            }
            else
            {
                try
                {
                    Guarantor_ guarantor_ = new Guarantor_();
                    guarantor_.Cedula = Convert.ToInt32(IdentificationCard_textBox1.Text.Trim());
                    guarantor_.Name = Name_textBox1.Text.Trim();
                    guarantor_.Debt = 0;
                    if (Guarantor_DB.SaveGuarantor(guarantor_))
                    {
                        Clean_Fields();
                        MessageBox.Show("GUARANTOR ADDED SUCCESSFULLY");
                    }
                    else
                    {
                        MessageBox.Show("THIS GUARANTOR ALREADY EXISTS");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
        private void Clean_Fields()
        {
            IdentificationCard_textBox1.Text = "";
            Name_textBox1.Text = "";
        }
    }
}
