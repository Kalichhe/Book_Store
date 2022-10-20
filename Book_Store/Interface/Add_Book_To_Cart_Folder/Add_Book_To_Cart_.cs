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

        private void Send_button1_Click(object sender, EventArgs e)
        {

        }
    }
}
