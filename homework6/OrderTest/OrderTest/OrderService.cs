using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OrderTest
{
    public class OrderService
    {
        private List<Order> Orders { get; } = new List<Order>();

        public void AddOrder(Order order)
        {
            if (order == null) throw new ApplicationException("$Invalid order");
            if (Orders.Contains(order)) throw new ApplicationException($"the order {order.Id} already exists!");
            Orders.Add(order);
        }
        public void DeleteOrder(int id)
        {
            Orders.RemoveAll(o => o.Id == id);
        }
        public void DeleteOrder(Order order)
        {
            Orders.RemoveAll(o => o.Id == order.Id);
        }
        public Order GetById(int orderId)
        {
            return Orders.Where(o => o.Id == orderId).FirstOrDefault();
        }
        public void ReplaceOrder(Order order)
        {
            if (order == null) throw new ApplicationException("the order does not exist.");
            DeleteOrder(order);
            Orders.Add(order);
        }
        public void Export()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Order[]));
            using (FileStream fs = new FileStream("s.xml", FileMode.Create))
            {
                Order[] orders = Orders.ToArray();
                xmlSerializer.Serialize(fs, orders);
            }
        }
        public void Import()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Order[]));
            using (FileStream fs = new FileStream("s.xml", FileMode.Open))
            {
                Order[] orders = (Order[])xmlSerializer.Deserialize(fs);
                foreach (Order order in orders)
                {
                    if (!Orders.Contains(order))
                    {
                        Orders.Add(order);
                    }
                }
            }
        }
        public void SortOrders()
        {
            Orders.Sort();
        }
        public void SortOrders(Comparison<Order> comparison)
        {
            Orders.Sort(comparison);
        }
        public List<Order> GetSortedOrders()
        {
            SortOrders();
            return Orders;
        }
        public List<Order> GetOrders()
        {
            return Orders;
        }
    }
}
