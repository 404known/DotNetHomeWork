namespace WinFormsCrawler
{
    public partial class Form1 : Form
    {

        SimpleCrawler simpleCrawler = new SimpleCrawler();
        public Form1()
        {
            InitializeComponent();
            simpleCrawler.GetUrlInfo += (url) =>
            {
                this.BeginInvoke(new Action<string>((ms) =>
                {
                    this.txtURLInfo.AppendText(ms);
                }), url);
            };
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            txtURLInfo.Clear();
            txtURLInfo.AppendText("¿ªÊ¼\n");
            ThreadPool.QueueUserWorkItem(new WaitCallback(simpleCrawler.Crawl), txtStartURL.Text);
        }
    }
}