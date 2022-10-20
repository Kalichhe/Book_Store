using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Store.Guarantor.Guarantor_1
{
    internal class Guarantor_
    {
        private int cedula;
        private string name;
        private int debt;

        public Guarantor_()
        {
            cedula = 0;
            name = "";
            debt = 0;
        }

        public int Cedula { get => cedula; set => cedula = value; }
        public string Name { get => name; set => name = value; }
        public int Debt { get => debt; set => debt = value; }
    }
}
