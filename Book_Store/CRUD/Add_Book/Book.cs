using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Store.CRUD.Add_Book
{
    internal class Book
    {
        private int code;
        private string name;
        private string category;
        private int amount;
        private int value;

        public Book()
        {
            this.code = 0;
            this.name = "";
            this.category = "";
            this.amount = 0;
            this.value = 0;
        }

        public int Code { get => code; set => code = value; }
        public string Name { get => name; set => name = value; }
        public string Category { get => category; set => category = value; }
        public int Amount { get => amount; set => amount = value; }
        public int Value { get => value; set => this.value = value; }
    }
}
