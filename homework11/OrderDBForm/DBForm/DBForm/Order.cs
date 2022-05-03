using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderTest
{
    
    [Serializable]
    public class Order :IComparable<Order>
    {
        public Order()
        {
        }
        public Order(int id, string clientName)
        {
            OrderId = id;
            ClientName = clientName;
        }
        [DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)]
        public int OrderId { get; set; }
        public string ClientName { get; set; }
        public List<OrderDetails> OrderDetails { get; set; } = new List<OrderDetails>();

        public override bool Equals(object obj)
        {
            return obj is Order order &&
                   OrderId == order.OrderId;
        }

        public override int GetHashCode()
        {
            return OrderId;
        }

        public override string ToString()
        {
            string description = "OrderID:" + OrderId + " Client:" + ClientName + " Total:" + GetTotal() + "\n";
            for (int i = 0; i < OrderDetails.Count; i++)
            {
                description += OrderDetails[i] + "\n";
            }
            return description;
        }
        public void AddOrderDetail(OrderDetails orderDetails)
        {
            OrderDetails.Add(orderDetails);
        }
        public double GetTotal()
        {
            double total = 0;
            for (int i = 0; i < OrderDetails.Count; i++)
            {
                total += OrderDetails[i].NumOfGoods * OrderDetails[i].Goods.GoodsPrice;
            }
            return total;
        }

        public int CompareTo(Order other)
        {
            if(other == null) return 1;
            return OrderId - other.OrderId;
        }
    }
}
