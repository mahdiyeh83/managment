using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aqababaee
{
    internal class shop
    {
        public string user { get; set; }
        public string media { get; set; }
        public shop(string user , string media)
        {
            this.user = user;
            this.media = media;
        }
    }
}
