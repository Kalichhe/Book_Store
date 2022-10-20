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
using Book_Store.Add_Book_To_Cart.Book_To_Cart;
using Book_Store.Add_Book_To_Cart;

namespace Book_Store.Interface.Book_Folder
{
    public partial class Add_Book_To_Cart_ : Form
    {
        public Add_Book_To_Cart_()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void ToClose_button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Send_button1_Click(object sender, EventArgs e) //Aqui
        {
            if (BookCode_textBox1.Text.Trim() == "")
            {
                MessageBox.Show("ENTER A CODE");
            } else if (Units_textBox1.Text.Trim() == "")
            {
                MessageBox.Show("ENTER THE UNITS");
            }
            else
            {
                try
                {
                    Book_To_Cart_ book_To_Cart_ = new Book_To_Cart_();
                    book_To_Cart_.Code = Convert.ToInt32(BookCode_textBox1.Text.Trim());
                    book_To_Cart_.Units = Convert.ToInt32(Units_textBox1.Text.Trim());
                    if (Book_To_Cart_DB.Add(book_To_Cart_))
                    {
                        Clean_Fields();
                        MessageBox.Show("BOOK SUCCESSFULLY ADDED TO CART");
                    }
                    else
                    {
                        Clean_Fields();
                        MessageBox.Show("BOOK NOT CORRECTLY ADDED TO CART");
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
            Units_textBox1.Text = "";
        }
    }
}   
