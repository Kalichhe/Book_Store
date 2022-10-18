using Book_Store.Interface.Guarantor_Folder;
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
    public partial class Guarantor : Form
    {
        public Guarantor()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void ToClose_button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Back_button1_Click(object sender, EventArgs e)
        {
            using (Book_ book_ = new Book_())
                book_.ShowDialog();
        }

        private void Ahead_button3_Click(object sender, EventArgs e)
        {
            using (Show_Book show_Book = new Show_Book())
                show_Book.ShowDialog();
        }

        private void AddGuarantor_button3_Click(object sender, EventArgs e)
        {
            using (Add_Guarantor add_Guarantor = new Add_Guarantor())
                add_Guarantor.ShowDialog();
        }

        private void ShowGuarantor_button3_Click(object sender, EventArgs e)
        {
            using (Show_Guarantor show_Guarantor = new Show_Guarantor())
                show_Guarantor.ShowDialog();
        }

        private void PayOffDebt_button1_Click(object sender, EventArgs e)
        {
            using (Pay_Off_Debt pay_Off_Debt = new Pay_Off_Debt())
                pay_Off_Debt.ShowDialog();
        }
    }
}
