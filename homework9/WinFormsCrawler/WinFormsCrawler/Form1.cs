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
                txtURLInfo.AppendText(url);
            };
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            txtURLInfo.Clear();
            txtURLInfo.AppendText("¿ªÊ¼\n");
            simpleCrawler.Crawl(txtStartURL.Text);
            txtURLInfo.AppendText("½áÊø\n");
        }
    }
}