using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aqababaee
{
    internal class karbar
    {
        public string name { get; set; }
        public string last_name { get; set; }
        public string phone_number { get; set; }
        public string gener { get; set; }
        public int code { get; set; }

        public karbar(string name, string last_name, string phone_number , string gener)
        {
            this.name = name;
            this.last_name = last_name;
            this.phone_number = phone_number;
            this.gener = gener;
        }

        internal string GetFullName()
        {
            return name + "\n" + last_name + Environment.NewLine + phone_number;
        }
        public override string ToString()
        {
            return name + "\n" + last_name + Environment.NewLine + phone_number;
        }
    }
}
