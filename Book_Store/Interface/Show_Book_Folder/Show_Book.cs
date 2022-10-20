using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_Store.Interface.Show_Book_Folder
{
    public partial class Show_Book : Form
    {
        public Show_Book()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void ToClose_button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Guarantor_button2_Click(object sender, EventArgs e)
        {
            using (Guarantor guarantor = new Guarantor())
                guarantor.ShowDialog();
        }

        private void Back_button1_Click(object sender, EventArgs e)
        {
            using (Guarantor guarantor = new Guarantor())
                guarantor.ShowDialog(this);
            this.Close();
        }

        private void Show_Book_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetBook.Book' table. You can move, or remove it, as needed.
            this.bookTableAdapter.Fill(this.dataSetBook.Book);
        }

    }
}
