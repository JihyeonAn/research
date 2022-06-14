using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace research
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            string result = "";
            if (r_korea.Checked)
                result += "선호하는 음식 : 한식\n";
            else if (r_china.Checked)
                result += "선호하는 음식 : 중식\n";
            else if (r_usa.Checked)
                result += "선호하는 음식 : 양식\n";
            else if (r_teo.Checked)
                result += "선호하는 음식 : 분식\n";
            else if (r_fastfood.Checked)
                result += "선호하는 음식 : 패스트푸드\n";

            MessageBox.Show(result, "선호하는 음식");


            Form3 window3 = new Form3();
            this.AddOwnedForm(window3);
            window3.Show();
            this.Hide();


        //private void pictureBox1_Click(object sender, EventArgs e)
            {

            }
        }
    }
}
