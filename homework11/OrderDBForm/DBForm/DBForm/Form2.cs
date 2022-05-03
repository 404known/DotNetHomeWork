using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderTest;

namespace OrderServiceWinForms
{
    public partial class Form2 : Form
    {
        public Order order { get; set; }
        public int NumOfGoods { get; set; }
        public string GoodName { get; set; }
        public double Price { get; set; }

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            order = new Order();
            txtOrderId.DataBindings.Add("Text", order, "OrderId");
            txtClientName.DataBindings.Add("Text", order, "ClientName");
            txtGoodsNum.DataBindings.Add("Text", this, "NumOfGoods");
            txtGoodsName.DataBindings.Add("Text", this, "GoodName");
            txtGoodsPrice.DataBindings.Add("Text", this, "Price");
            orderBds.DataSource = order;
        }

        private void btnAddOrderDetails_Click(object sender, EventArgs e)
        {
            Goods goods = new Goods(GoodName, Price);
            OrderDetails orderDetails = new OrderDetails(NumOfGoods, goods);
            order.AddOrderDetail(orderDetails);
            orderBds.ResetBindings(false);
        }
    }
}
