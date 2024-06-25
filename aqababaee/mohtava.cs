using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace aqababaee
{
    internal class mohtava
    {
        public string title { get; set; }
        public DateTime sal_enteshar { get; set; }
        public string nasher { get; set; }
        public string code { get; set; }
        public mohtava(string title,DateTime sal_enteshar,string nasher, string code)
        {
            this.title = title;
            this.sal_enteshar = sal_enteshar;
            this.nasher = nasher;
            
        }

 
        public override string ToString()
        {
            return title+"\n"+sal_enteshar+"\n"+nasher;
        }
    }
}
