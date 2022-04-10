using System;
using System.Collections.Generic;
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
            Id = id;
            ClientName = clientName;
        }
        public int Id { get; set; }
        public string ClientName { get; set; }
        public List<OrderDetails> OrderDetails { get; set; } = new List<OrderDetails>();

        public override bool Equals(object? obj)
        {
            return obj is Order order &&
                   Id == order.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            string description = "OrderID:" + Id + " Client:" + ClientName + " Total:" + GetTotal() + "\n";
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

        public int CompareTo(Order? other)
        {
            if(other == null) return 1;
            return Id - other.Id;
        }
    }
}
