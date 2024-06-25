using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aqababaee
{
    internal class database
    {
        private static karbar[] karbars = new karbar[100];
        private static int iu = 0;
        public static List<mohtava> mohtavas = new List<mohtava>();
        public static List<shop> shops = new List<shop>();

        public static void Add(karbar a)
        {
            if (iu < 100)
            {
                karbars[iu] = a;
                iu++;
            }
        }

        public static void Add(mohtava b)
        {
            mohtavas.Add(b);
        }
        public static void Add(shop sh) 
        {
            shops.Add(sh);
        }

        public static string Search(int code)
        {
            for (int i = 0; i < iu; i++)
            {
                if (karbars[i].code == code)
                {
                    return karbars[i].GetFullName();
                }
            }
            return null;
        }

        public static string search(string id)
        {

            return mohtavas.Find(b => b.code == id).title;
        }
    }
}
