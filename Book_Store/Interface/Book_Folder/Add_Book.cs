using Book_Store.CRUD;
using Book_Store.CRUD.Add_Book;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_Store.Interface.Book_Folder
{
    public partial class Add_Book : Form
    {
        public Add_Book()
        {
            InitializeComponent();
            this.CenterToScreen();  
        }

        private void Send_button1_Click(object sender, EventArgs e) //Aqui
        {
            if (BookCode_textBox1.Text.Trim() == "")
            {
                MessageBox.Show("ENTER A CODE");
            }else if (BookName_textBox1.Text.Trim().Length < 4)
            {
                MessageBox.Show("ENTER A LONGER NAME");
            }else if (BookCategory_textBox1.Text.Trim() == "")
            {
                MessageBox.Show("ENTER A CATEGORY");
            }else if (BookAmount_textBox1.Text.Trim() == "")
            {
                MessageBox.Show("ENTER A AMOUNT");
            }else if (BookValue_textBox1.Text.Trim() == "")
            {
                MessageBox.Show("ENTER A VALUE");
            }
            else
            {
                try
                {
                    Book book = new Book();
                    book.Code = Convert.ToInt32(BookCode_textBox1.Text.Trim());
                    book.Name = BookName_textBox1.Text.Trim().ToUpper();
                    book.Category = BookCategory_textBox1.Text.Trim().ToUpper();
                    book.Amount = Convert.ToInt32(BookAmount_textBox1.Text.Trim());
                    book.Value = Convert.ToInt32(BookValue_textBox1.Text.Trim());
                    if (Book_DB.Save(book))
                    {
                        Clean_Fields();
                        MessageBox.Show("BOOK ADDED SUCCESSFULLY");
                    }
                    else
                    {
                        MessageBox.Show("THIS BOOK ALREADY EXISTS");
                    }
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }

        private void ToClose_button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BookCode_textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Clean_Fields()
        {
            BookCode_textBox1.Text = "";
            BookName_textBox1.Text = "";
            BookCategory_textBox1.Text = "";
            BookAmount_textBox1.Text = "";
            BookValue_textBox1.Text = "";
        }
    }
}
