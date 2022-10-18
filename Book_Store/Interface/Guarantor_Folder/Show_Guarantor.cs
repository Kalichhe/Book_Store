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
    public partial class Show_Guarantor : Form
    {
        public Show_Guarantor()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void Show_Guarantor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetGuarantor.Guarantor' table. You can move, or remove it, as needed.

        }

        private void ToClose_button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
