using OrderTest;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using System.Data.Entity;

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
            GetAllOrdersFromDB();
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
            using(var db = new OrderContext())
            {
                db.Orders.Add(form.order);
             //   foreach(OrderDetails details in form.order.OrderDetails)
             //   {
             //       db.goods.Attach(details.Goods);
             //   }
                db.SaveChanges();
            }
            GetAllOrdersFromDB();
            orderListBindingSource.ResetBindings(false);
            OrderdetailBindingSource.ResetBindings(false);
        }

        private void searchBtn_Click(object sender, System.EventArgs e)
        {
            if (searchCbx.SelectedIndex == 0)
            {
                //orderListBindingSource.DataSource = orderService.GetById(searchId);
                using(var db = new OrderContext())
                {
                    orderListBindingSource.DataSource = db.Orders
                                                          .Include(o => o.OrderDetails)
                                                          .Include(o => o.OrderDetails.Select(d => d.Goods))
                                                          .Where(o=>o.OrderId==searchId)
                                                          .FirstOrDefault();
                }
            }
            else if (searchCbx.SelectedIndex == 1)
            {
                //orderListBindingSource.DataSource = orderService.GetByCustomerName(searchName);
                using(var db = new OrderContext())
                {
                    orderListBindingSource.DataSource = db.Orders
                                                          .Include(o => o.OrderDetails)
                                                          .Include(o => o.OrderDetails.Select(d => d.Goods))
                                                          .Where(o => o.ClientName == searchName)
                                                          .FirstOrDefault();
                }
            }
            else if( searchCbx.SelectedIndex == 2)
            {
                //orderListBindingSource.DataSource = orderService.Orders;
                GetAllOrdersFromDB();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // orderListBindingSource.DataSource = orderService;
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
           // orderService.DeleteOrder((Order)orderListBindingSource.Current);
           using(var db=new OrderContext())
            {
                Order current = (Order)orderListBindingSource.Current;
                var deleteOrder = db.Orders.Include(o=>o.OrderDetails).FirstOrDefault(o => o.OrderId == current.OrderId);
                db.Orders.Remove(deleteOrder);
                db.SaveChanges();
            }
            GetAllOrdersFromDB();
            orderListBindingSource.ResetBindings(false);
            OrderdetailBindingSource.ResetBindings(false);

        }

        private void btnChangeOrder_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();
            //orderService.ReplaceOrder(form.order);
            using(var db=new OrderContext())
            {
                var oldOrder = db.Orders.FirstOrDefault(o => o.OrderId == form.order.OrderId);
                if(oldOrder != null) db.Orders.Remove(oldOrder);
                db.Orders.Add(form.order);
                db.SaveChanges();
            }
            GetAllOrdersFromDB();
            orderListBindingSource.ResetBindings(false);
            OrderdetailBindingSource.ResetBindings(false);
        }
        private void GetAllOrdersFromDB()
        {
            using (var db = new OrderContext())
            {
                var query = db.Orders
                    .Include(o => o.OrderDetails)
                    .Include(o => o.OrderDetails.Select(d => d.Goods))
                    .ToList();
                orderListBindingSource.DataSource = query;
            }
        }
    }
}