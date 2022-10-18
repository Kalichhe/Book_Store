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
    public partial class Check_Amount : Form
    {
        public Check_Amount()
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
            MessageBox.Show("Enviado");
            this.Close();
        }
    }
}
