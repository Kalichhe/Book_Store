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

namespace Book_Store.Interface.Book_Folder
{
    public partial class Delete_Book : Form
    {
        public Delete_Book()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void Send_button1_Click(object sender, EventArgs e) //Aqui
        {
            if (BookCode_textBox1.Text.Trim() == "")
            {
                MessageBox.Show("ENTER A CODE");
            }
            else
            {
                try
                {
                    if (Book_DB.Delete(Convert.ToInt32(BookCode_textBox1.Text.Trim())))
                    {
                        Clean_Fields();
                        MessageBox.Show("BOOK DELETE SUCCESSFULLY");
                    }
                    else
                    {
                        MessageBox.Show("COULD NOT DELETE BOOK");
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
            BookCode_textBox1.Text = "";
        }

        private void ToClose_button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShoppingCart_button2_Click(object sender, EventArgs e)
        {
            using (Shopping_Cart shopping_Cart = new Shopping_Cart())
                shopping_Cart.ShowDialog();
        }
    }
}
