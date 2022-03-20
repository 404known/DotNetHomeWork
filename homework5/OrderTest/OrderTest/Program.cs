using System;
using System.Linq;

namespace OrderTest
{
    public class Test
    {
        public static void Main()
        {
            OrderService orderService = new OrderService();
            bool stop = false;
            while (!stop)
            {
                Console.WriteLine("Please input 1 to add an order, 2 to delete an order, 3 to change an order, 4 to search an order, 5 to print all orders, 6 to quit");
                int choice = Int32.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1: Console.WriteLine("Input order id"); int id1 = int.Parse(Console.ReadLine()); orderService.AddOrder(id1); break;
                    case 2: Console.WriteLine("Input order id"); int id2 = int.Parse(Console.ReadLine()); orderService.DeleteOrder(id2); break;
                    case 3: orderService.ChangeOrder(); break;
                    case 4: orderService.SearchOrder(); break;
                    case 5: orderService.ShowAllOrder(); break;
                    case 6: stop = true; break;
                    default: Console.WriteLine("Invalid input"); break;
                }
            }
        }
    }

    public class Order
    {
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
            string description = "OrderID:" + Id + " Client:" + ClientName + " Total:" + GetTotal()+ "\n";
            for(int i = 0; i < OrderDetails.Count; i++)
            {
                description += OrderDetails[i] + "\n";
            }
            return description;
        }
        public void AddOrderDetail()
        {
            Console.WriteLine("please input the number of goods.");
            int numOfGoods = Int32.Parse(Console.ReadLine());
            Console.WriteLine("please input discount");
            bool isLegal = false;
            double discount=0;
            while (!isLegal)
            {
                discount = Double.Parse(Console.ReadLine());
                if(discount > 0 && discount <= 1)
                {
                    isLegal = true;
                }
                else
                {
                    Console.WriteLine("illegal discount input, please input again.");
                }
            }
            Console.WriteLine("please input goods name");
            string goodsName = Console.ReadLine();
            Console.WriteLine("please input price");
            isLegal = false;
            double price=0;
            while (!isLegal)
            {
                price = Double.Parse(Console.ReadLine());
                if (price >= 0) isLegal = true;
                else   Console.WriteLine("illegal price input, please input again.");
            }
            OrderDetails.Add(new OrderDetails(numOfGoods, discount, goodsName, price));
        }
        public double GetTotal()
        {
            double total = 0;
            for(int i = 0; i < OrderDetails.Count; i++)
            {
                total += OrderDetails[i].Discount * OrderDetails[i].NumOfGoods * OrderDetails[i].Goods.GoodsPrice;
            }
            return total;
        }
    }

    public class OrderDetails
    {
        public OrderDetails(int numOfGoods, double discount,string goodsName, double price )
        {
            NumOfGoods = numOfGoods;
            Discount = discount;
            Goods = new Goods(goodsName, price);
        }
        public int NumOfGoods { get; set; }
        public Goods Goods { get; set; }
        public double Discount { get; set; }
        public override string ToString()
        {
            return "Name of goods:" +Goods.GoodsName+",price of goods:"+Goods.GoodsPrice+
                ", number of goods:"+NumOfGoods+ ", discount:"+Discount;
        }
    }


    public class Goods
    {
        public Goods(string goodsName, double goodsPrice)
        {
            GoodsName = goodsName;
            GoodsPrice = goodsPrice;
        }

        public string GoodsName { get; set; }
        public double GoodsPrice { get; set; }
        public override string ToString()
        {
            return "Name of Goods:"+GoodsName+" Price:"+GoodsPrice;
        }
    }

    public class OrderService
    {
        public List<Order> Orders { get; set; } = new List<Order>();

        public void AddOrder(int id)
        {
            Order order;
            Console.WriteLine("Please input clientname");
            string clientname = Console.ReadLine();
            order = new Order(id, clientname);
            bool same = false;
            foreach (Order item in Orders)
            {
                if (item.Equals(order)) same = true;
            }
            if (same)
            {
                Console.WriteLine("There is a duplication in id. Fail to add.");
                return;
            }
            Console.WriteLine("Please input how many orderdetails do you want to input.");
            int numofod = Int32.Parse(Console.ReadLine());
            for(int i = 0; i < numofod; i++)
            {
                order.AddOrderDetail();
            }
            Orders.Add(order);
        }
        public bool DeleteOrder(int id)
        {
            for(int i = 0; i < Orders.Count; i++)
            {
                if(Orders[i].Id == id)
                {
                    Orders.RemoveAt(i);
                    return true;
                }
            }
            Console.WriteLine("fail to find this order id");
            return false;
        }
        public void ChangeOrder()
        {
            Console.WriteLine("Please input the order id which you want to change.");
            int id = Int32.Parse(Console.ReadLine());
            if (!DeleteOrder(id)) return;
            AddOrder(id);
        }
        public void ShowAllOrder()
        {
            foreach (Order order in Orders)
            {
                Console.WriteLine(order);
            }
            Console.WriteLine("All is shown");
        }
        public void SearchOrder()
        {
            Console.WriteLine("Input 1 to search by order id, 2 to search by client name.");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1) {
                Console.WriteLine("Input the id");
                int id = int.Parse(Console.ReadLine());
                var quest = from ord in Orders
                            where ord.Id == id
                            orderby ord.GetTotal()
                            select ord;
                foreach(Order order in quest)
                    Console.WriteLine(order);
            }
            else if (choice == 2)
            {
                Console.WriteLine("Input the client name");
                string name = Console.ReadLine();
                var quest = from ord in Orders
                            where ord.ClientName == name
                            orderby ord.GetTotal()
                            select ord;
                foreach (Order order in quest)
                    Console.WriteLine(order);
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}