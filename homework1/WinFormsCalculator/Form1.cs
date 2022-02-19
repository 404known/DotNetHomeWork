namespace WinFormsCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int m = Int32.Parse(textBox1.Text);
            int n = Int32.Parse(textBox2.Text);
            if (radioButton1.Checked)
            {
                int o = m + n;
                label1.Text = o.ToString();
            }
            else if (radioButton2.Checked)
            {
                int o = m - n;
                label1.Text = o.ToString();
            }
            else if (radioButton3.Checked)
            {
                int o = m * n;
                label1.Text = o.ToString();
            }
            else if (radioButton4.Checked)
            {
                if(n == 0) label1.Text = "Invalid input";
                else
                {
                    int o = m / n;
                    label1.Text = o.ToString();
                }   
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}