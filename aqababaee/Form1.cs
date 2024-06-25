using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace aqababaee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mohtava_Click(object sender, EventArgs e)
        {
            
            var i = new media();
            i.Show();
        }

        private void karbar_Click(object sender, EventArgs e)
        {
            try
            {

                if (active.Checked == true)
                {
                    karbar u = new karbar(txt_name.Text, text_last.Text, number.Text, comboBox1.SelectedItem.ToString());
                    listBox1.Items.Add(u.name + " " + u.last_name + "  " + u.phone_number);
                    database.Add(u);
                    MessageBox.Show("ثبت با موفقیت انجام شد");
                }

            }
            catch
            {
                MessageBox.Show("مقادیر را درست وارد کنید");
            }
            
        }
    }
}
