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
    public partial class Units_Nearing_Depletion_ : Form
    {
        public Units_Nearing_Depletion_()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void ToClose_button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Units_Nearing_Depletion__Load(object sender, EventArgs e)
        {
            this.book1TableAdapter.Amount(this.dataSetBook.Book1);
        }
    }
}
