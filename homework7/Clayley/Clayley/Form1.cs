using System.Drawing;

namespace Clayley
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        public Form1()
        {
            InitializeComponent();
        }
        double th1;
        double th2;
        double per1;
        double per2;
        int curLn;
        Pen pen;
        private void button1_Click(object sender, EventArgs e)
        {
            if(graphics == null) graphics = panel2.CreateGraphics();
            if (!IsLegal()) return;
            th1 = double.Parse(rightAn.Text) * Math.PI / 180;
            th2 = double.Parse(leftAn.Text) * Math.PI / 180;
            per1 = double.Parse(rightRate.Text);
            per2 = double.Parse(leftRate.Text);
            curLn = int.Parse(cursiveDepth.Text);
            double mLen = double.Parse(mainLen.Text);
            string pe = (String) comboBox1.SelectedItem;
            switch (pe)
            {
                case "À¶É«": pen = Pens.Blue; break;
                case "ºÚÉ«": pen = Pens.Black; break;
                case "ºìÉ«": pen = Pens.Red; break;
            }
            drawCayleyTree(curLn, 200, 310, mLen, -Math.PI / 2);
        }
        private bool IsNumber(string s)
        {
            if(s == null || s.Length == 0) return false;
            for (int i = 0; i < s.Length; i++)
            {
                if(s[i] < '0' && s[i] > '9') return false;
            }
            return true;
        }
        private bool IsDouble(string s)
        {
            if(s == null || s.Length == 0) return false;
            int i = 0;
            for (; i < s.Length; i++)
            {
                if (s[i] == '.') break;
                if(s[i] < '0' && s[i] > '9') return false;
            }
            i++;
            for (; i < s.Length; i++)
            {
                if (s[i] < '0' && s[i] > '9') return false;
            }
            return true;
        }
        private bool IsLegal()
        {
            if (!IsDouble(rightAn.Text)) return false;
            if (!IsDouble(leftAn.Text)) return false;
            if (!IsDouble(rightRate.Text)) return false;
            if (!IsDouble(leftRate.Text)) return false;
            if (!IsNumber(cursiveDepth.Text)) return false;
            if (!IsDouble(mainLen.Text)) return false;
            if(pen == null) return false;
            return true;
        }
        private void drawCayleyTree(int n,
            double x0, double y0, double leng, double th)
        {
            if(n == 0) return;
            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);

            drawLine(x0, y0, x1, y1);

            drawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1);
            drawCayleyTree(n - 1, x1, y1, per2 * leng, th - th2);
        }

        void drawLine(double x0, double y0, double x1, double y1)
        {
            graphics.DrawLine(
                pen,
                (int) x0, (int) y0, (int) x1, (int) y1);
        }
    }
}