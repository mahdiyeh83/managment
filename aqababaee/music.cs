using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aqababaee
{
    internal class music : mohtava
    {
        public int id { get; set; }
        public music(string code, string title, DateTime sal, string nasher) : base(title, sal, nasher,code)
        {
            id = id;
        }

        public override string ToString()
        {
            return id + "\n" + title + "\n" + sal_enteshar + "\n" + nasher;
        }
    }
}
