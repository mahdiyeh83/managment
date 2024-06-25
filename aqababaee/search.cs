using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aqababaee
{
    public partial class search : Form
    {
        public search()
        {
            InitializeComponent();
        }
        private void search_btn_Click(object sender, EventArgs e)
        {
            try
            {
                var x1 = database.mohtavas.Find(x => x.title == textmohtava.Text);
                MessageBox.Show((x1.title, x1.nasher, x1.sal_enteshar).ToString());
            }
            catch
            {
                MessageBox.Show("...متاسفانه پیدا نشد.");
            }
        }

        private void buy_Click(object sender, EventArgs e)
        {
            MessageBox.Show("...خرید با موفقیت انجام شد");
        }
    }
}
