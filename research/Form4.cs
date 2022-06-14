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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string result = "";
            if (rd_1.Checked)
                result += "제출결과 : 배달로 시키면 맛이 달라져서\n";
            else if (rd_2.Checked)
                result += "제출결과 : 배달이 가능한 종류가 아니라서\n";
            else if (rd_3.Checked)
                result += "제출결과 : 배달시간이 너무 오래 걸려서\n";
            else if (rd_4.Checked)
                result += "제출결과 : 선호하는 음식과 배달로 선호하는 음식이 같음\n";

            MessageBox.Show(result, "result");

            Close();
            
        }
    }
}
