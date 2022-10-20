using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Store.Model.Sell_Book.Sell
{
    internal class Sell_Book_
    {
        private int id_book;
        private int id_guarantor;

        public Sell_Book_()
        {
            this.id_book = 0;
            this.id_guarantor = 0;
        }

        public int Id_book { get => id_book; set => id_book = value; }
        public int Id_guarantor { get => id_guarantor; set => id_guarantor = value; }
    }
}
