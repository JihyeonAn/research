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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string result = "";
            if (rd_korea.Checked)
                result += "선호하는 음식 : 한식\n";
            else if (rd_china.Checked)
                result += "선호하는 음식 : 중식\n";
            else if (rd_usa.Checked)
                result += "선호하는 음식 : 양식\n";
            else if (rd_teo.Checked)
                result += "선호하는 음식 : 분식\n";
            else if (rd_fastfood.Checked)
                result += "선호하는 음식 : 패스트푸드\n";

            MessageBox.Show(result, "배달로 선호하는 음식");


            Form4 frm = new Form4();
            this.AddOwnedForm(frm);
            frm.Show();
            this.Hide();
        }
    }
}
