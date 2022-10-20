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
    public partial class Check_Amount_ : Form
    {
        public Check_Amount_()
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
                    MessageBox.Show("THE QUANTITY OF BOOKS YOU HAVE ARE " + Convert.ToString(book.Amount)+"");
                    Clean_Fields();
                }
            }
        }
        private void Clean_Fields()
        {
            BookCode_textBox1.Text = "";
        }
    }
}
