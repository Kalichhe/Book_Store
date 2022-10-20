using Book_Store.Interface.Book_Folder;
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
    public partial class Book_ : Form
    {
        public Book_()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void DecreaseBook_button3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Back_button3_Click(object sender, EventArgs e)
        {

        }

        private void CheckAmount_button3_Click(object sender, EventArgs e)
        {
            using (Check_Amount_ check_Amount_ = new Check_Amount_())
                check_Amount_.ShowDialog();
        }

        private void SellBook_button3_Click(object sender, EventArgs e)
        {

        }

        private void ValidateBook_button3_Click(object sender, EventArgs e)
        {
            using (Validate_Book validate_Book = new Validate_Book())
                validate_Book.ShowDialog();
        }

        private void DeleteBook_button3_Click(object sender, EventArgs e)
        {
            using (Delete_Book delete_Book = new Delete_Book())
                delete_Book.ShowDialog();
        }

        private void ModifyBook_button4_Click(object sender, EventArgs e)
        {
            using (Modify_Book modify_Book = new Modify_Book())
                modify_Book.ShowDialog();
        }

        private void AddBook_button3_Click(object sender, EventArgs e)
        {

            using (Add_Book add_Book = new Add_Book())
                add_Book.ShowDialog();
            
        }

        private void UnitsNearingDepletion_button3_Click(object sender, EventArgs e)
        {
            using (Units_Nearing_Depletion_ units_Nearing_Depletion = new Units_Nearing_Depletion_())
                units_Nearing_Depletion.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (Shopping_Cart shopping_Cart = new Shopping_Cart())
                shopping_Cart.ShowDialog();
        }

        private void ToClose_button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowBook_button2_Click(object sender, EventArgs e)
        {
            using (Show_Book show_Book = new Show_Book())
                show_Book.ShowDialog();
        }

        private void Back_button1_Click(object sender, EventArgs e)
        {
            using (Main main = new Main())
                main.ShowDialog();
            this.Close();
        }

        private void Ahead_button3_Click(object sender, EventArgs e)
        {
            using (Guarantor guarantor = new Guarantor())
                guarantor.ShowDialog();
            this.Close();
        }

        private void AddBookToCart_button1_Click(object sender, EventArgs e)
        {
            using(Add_Book_To_Cart_ add_Book_To_Cart = new Book_Folder.Add_Book_To_Cart_())
                add_Book_To_Cart.ShowDialog();
        }
    }
}
