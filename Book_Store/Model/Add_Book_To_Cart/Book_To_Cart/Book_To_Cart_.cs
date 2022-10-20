using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Store.Add_Book_To_Cart.Book_To_Cart
{
    internal class Book_To_Cart_
    {
        private int units;
        private int code;

        public Book_To_Cart_()
        {
            units = 0;
            code = 0;
        }

        public int Units { get => units; set => units = value; }
        public int Code { get => code; set => code = value; }
    }
}
