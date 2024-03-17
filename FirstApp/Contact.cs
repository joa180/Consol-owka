using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    internal class Contact
    {
        public Contact(string number, string name)
        {
            Number = number;
            Name = name;
        }
        public string Number { get; set; }
        public string Name { get; set; }
    }
}
