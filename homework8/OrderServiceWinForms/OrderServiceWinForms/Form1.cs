using OrderTest;

namespace OrderServiceWinForms
{
    public partial class Form1 : Form
    {
        public int searchId { get; set; }
        public string searchName { get; set; }
        OrderService orderService = new OrderService();
        private OpenFileDialog openFileDialog1 = new OpenFileDialog();
        private SaveFileDialog saveFileDialog1 = new SaveFileDialog();
        public Form1()
        {
            InitializeComponent();
        }

        private void searchCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (searchCbx.SelectedIndex == 0)
            {
                txtSearchInform.DataBindings.Clear();
                txtSearchInform.DataBindings.Add("Text", this, "searchId");
            }
            else if (searchCbx.SelectedIndex == 1)
            {
                txtSearchInform.DataBindings.Clear();
                txtSearchInform.DataBindings.Add("Text", this, "searchName");
            }
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();
            orderService.AddOrder(form.order);
            orderListBindingSource.ResetBindings(false);
            OrderdetailBindingSource.ResetBindings(false);
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (searchCbx.SelectedIndex == 0)
            {
                orderListBindingSource.DataSource = orderService.GetById(searchId);
            }
            else if (searchCbx.SelectedIndex == 1)
            {
                orderListBindingSource.DataSource = orderService.GetByCustomerName(searchName);
            }
            else if( searchCbx.SelectedIndex == 2)
            {
                orderListBindingSource.DataSource = orderService.Orders;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            orderListBindingSource.DataSource = orderService;
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                orderService.Import(openFileDialog1.FileName);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                orderService.Export(saveFileDialog1.FileName);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            orderService.DeleteOrder((Order)orderListBindingSource.Current);
            orderListBindingSource.ResetBindings(false);
            OrderdetailBindingSource.ResetBindings(false);

        }

        private void btnChangeOrder_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();
            orderService.ReplaceOrder(form.order);
            orderListBindingSource.ResetBindings(false);
            OrderdetailBindingSource.ResetBindings(false);
        }
    }
}