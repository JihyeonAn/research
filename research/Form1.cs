namespace research
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Form2 window2 = new Form2();
            this.AddOwnedForm(window2);
            window2.Show();
            this.Hide();
        }
    }
}