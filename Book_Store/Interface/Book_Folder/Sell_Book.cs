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
    public partial class Sell_Book : Form
    {
        public Sell_Book()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void Send_button1_Click(object sender, EventArgs e)//Aqui
        {
            if (BookCode_textBox1.Text.Trim() == "")
            {
                MessageBox.Show("ENTER ID GUARANTOR");
            }
            else{

            }
        }
    }
}
