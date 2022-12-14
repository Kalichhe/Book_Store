using Book_Store.Interface.Show_Book_Folder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_Store.Interface
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            this.CenterToScreen();
            
        }

        private void Book_button1_Click(object sender, EventArgs e)
        {
            using (Book_ book_ = new Book_())
                book_.ShowDialog();
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

        private void ShowBook_button2_Click(object sender, EventArgs e)
        {
            using (Show_Book show_Book = new Show_Book())
                show_Book.ShowDialog();
        }

        private void Guarantor_button2_Click(object sender, EventArgs e)
        {
            using (Guarantor guarantor = new Guarantor())
                guarantor.ShowDialog();
        }
    }
}
