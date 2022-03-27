using System;
using System.Linq;
using System.Xml.Serialization;
using System.Xml;

namespace OrderTest
{
    public class Test
    {
        public static OrderService orderService = new OrderService();
        public static void Main()
        {
            bool stop = false;
            while (!stop)
            {
                Console.WriteLine("---------------------------------------------------------------------");
                Console.WriteLine("Please input 1 to add an order, 2 to delete an order, 3 to change an existing order or create a new order, 4 to search an order, 5 to print all orders, 6 to quit， 7 to export current order, 8 to import order.");
                int choice = Int32.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1: AddAnOrder(); break;
                    case 2: Console.WriteLine("please input order Id to delete"); int id1 = int.Parse(Console.ReadLine()); DeleteAnOrder(id1); break;
                    case 3: ChangeAnOrder(); break;
                    case 4: SearchAnOrder(); break;
                    case 5: PrintAll(); break;
                    case 6: stop = true; break;
                    case 7: orderService.Export(); break;
                    case 8: orderService.Import(); break;
                    default: Console.WriteLine("Invalid input"); break;
                }
            }
        }
        public static Order CreateAnOrder()
        {
            Console.WriteLine("please input order Id"); 
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("please input customer's name");
            string name = Console.ReadLine();
            Order order = new Order(id, name);
            Console.WriteLine("How many order details do you want to add");
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("please input the goods name and price.");
                string goodsName = Console.ReadLine();
                double price = double.Parse(Console.ReadLine());
                Goods goods = new Goods(goodsName, price);
                Console.WriteLine("please input the number of goods and their discount");
                int number = int.Parse(Console.ReadLine());
                double discount = double.Parse(Console.ReadLine());
                OrderDetails orderDetails = new OrderDetails(number, goods);
                order.AddOrderDetail(orderDetails);
            }
            return order;
        }
        public static void AddAnOrder()
        {
            Order order = CreateAnOrder();
            orderService.AddOrder(order);
        }
        public static void DeleteAnOrder(int id)
        {
            orderService.DeleteOrder(id);
        }
        public static void ChangeAnOrder()
        {
            Order order = CreateAnOrder();
            orderService.ReplaceOrder(order);
        }
        public static void PrintAll()
        {
            orderService.SortOrders();
            orderService.GetSortedOrders().ForEach(order => Console.WriteLine(order));
        }
        public static void SearchAnOrder()
        {
            Console.WriteLine("please input 1 to search by id, 2 to search by min order total.");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Please input order id to find.");
                    int id = int.Parse(Console.ReadLine());
                    var qur1 = orderService.GetOrders().Where(order => order.Id == id);
                    foreach(var qur in qur1)
                    {
                        Console.WriteLine(qur);
                    }
                    break;
                case 2:
                    Console.WriteLine("Please input min order total.");
                    int minn = int.Parse(Console.ReadLine());
                    var qur2 = orderService.GetOrders().Where(order => order.GetTotal() >= minn).OrderBy(order => order.Id);
                    foreach (var qur in qur2)
                    {
                        Console.WriteLine(qur);
                    }
                    break;
            }
        }
    }
}