using Book_Store.CRUD;
using Book_Store.CRUD.Add_Book;
using Book_Store.Interface.Book_Folder;
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
    public partial class Validate_Book : Form
    {
        public Validate_Book()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void Send_button1_Click(object sender, EventArgs e)//Aqui
        {
            if (BookCode_textBox1.Text.Trim() == "")
            {
                MessageBox.Show("ENTER A CODE");
            }
            else
            {
                Book book = Book_DB.Validate_Book(Convert.ToInt32(BookCode_textBox1.Text.Trim()));
                if (book == null)
                {
                    MessageBox.Show("THIS BOOK DOES NOT EXIST");
                    Clean_Fields();
                }
                else
                {
                    MessageBox.Show("THE BOOK DOES EXIST");
                    Clean_Fields();
                    
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
    }
}
