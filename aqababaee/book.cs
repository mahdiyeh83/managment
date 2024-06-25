using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aqababaee
{
    internal class book:mohtava
    {
        public book(string code, string title, DateTime sal, string nasher) : base(title,sal,nasher,code)
        {
            
        }

        public override string ToString()
        {
            return title + "\n" +sal_enteshar+ "\n"+ nasher  + "\n" + code;
        }
    }
}
