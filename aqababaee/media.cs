using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace aqababaee
{
    public partial class media : Form
    {
        public media()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var i = new search();
            i.Show();
        }
        private void mohtava_Click(object sender, EventArgs e)
        {
            try
            {
                if (rb_book.Checked)
                {
                    book book = new book(code.Text, onvan.Text, monthCalendar1.SelectionEnd, nasher.Text);

                    database.Add(book);
                    listBox2.Items.Add(book.code + "   " + book.title + "   " + book.nasher + "   " + Environment.NewLine + book.sal_enteshar);
                }
                if (rb_music.Checked)
                {
                    music m = new music(code.Text, onvan.Text, monthCalendar1.SelectionStart, nasher.Text);
                    database.Add(m);
                    listBox2.Items.Add(m.code + "   " + m.title + "   " + m.nasher + "   " + m.sal_enteshar);
                }
            }
            catch
            {
                MessageBox.Show("مقادیر را درست وارد کنید");
            }

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime selectedDate = monthCalendar1.SelectionRange.Start;
        }
    }
}
