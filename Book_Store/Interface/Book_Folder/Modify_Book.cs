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
    public partial class Modify_Book : Form
    {
        public Modify_Book()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void ToClose_button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (Shopping_Cart shopping_Cart = new Shopping_Cart())
                shopping_Cart.ShowDialog();
        }

        private void Send_button1_Click(object sender, EventArgs e)//Aqui
        {
            if (NewBookCode_textBox1.Text.Trim() == "")
            {
                MessageBox.Show("ENTER A CODE");
            }
            else if (NewBookName_textBox1.Text.Trim().Length < 4)
            {
                MessageBox.Show("ENTER A LONGER NAME");
            }
            else if (NewBookCategory_textBox1.Text.Trim() == "")
            {
                MessageBox.Show("ENTER A CATEGORY");
            }
            else if (NewBookAmount_textBox1.Text.Trim() == "")
            {
                MessageBox.Show("ENTER A AMOUNT");
            }
            else if (NewBookValue_textBox1.Text.Trim() == "")
            {
                MessageBox.Show("ENTER A VALUE");
            }
            else
            {
                try
                {
                    Book book = new Book();
                    book.Code = Convert.ToInt32(NewBookCode_textBox1.Text.Trim());
                    book.Name = NewBookCategory_textBox1.Text.Trim().ToUpper();
                    book.Category = NewBookCategory_textBox1.Text.Trim().ToUpper();
                    book.Amount = Convert.ToInt32(NewBookAmount_textBox1.Text.Trim());
                    book.Value = Convert.ToInt32(NewBookValue_textBox1.Text.Trim());
                    if (Book_DB.Modify(book))
                    {
                        Clean_Fields();
                        MessageBox.Show("BOOK UPDATED SUCCESSFULLY");
                    }
                    else
                    {
                        MessageBox.Show("NOT UPDATED CORRECTLY");
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
            NewBookCode_textBox1.Text = "";
            NewBookName_textBox1.Text = "";
            NewBookCategory_textBox1.Text = "";
            NewBookAmount_textBox1.Text = "";
            NewBookValue_textBox1.Text = "";
        }
    }
}
