using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_Store.Interface.Guarantor_Folder
{
    public partial class Pay_Off_Debt : Form
    {
        public Pay_Off_Debt()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void Pay_Off_Debt_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetPayOffDebt.Cart' table. You can move, or remove it, as needed.

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ToClose_button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
