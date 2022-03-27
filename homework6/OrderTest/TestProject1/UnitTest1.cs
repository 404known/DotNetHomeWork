using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OrderTest;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddOrder1()
        {
            OrderService orderService = new OrderService();
            Order order = new Order(1, "Tom");
            Goods goods = new Goods("milk", 20);
            OrderDetails orderDetails = new OrderDetails(1, goods);
            order.AddOrderDetail(orderDetails);
            orderService.AddOrder(order);
            Assert.AreEqual(order, orderService.GetById(1));
        }
        [TestMethod]
        [ExpectedException(typeof(ApplicationException))]
        public void AddOrder2()
        {
            OrderService orderService = new OrderService();
            orderService.AddOrder(null);
        }
        [TestMethod]
        [ExpectedException(typeof(ApplicationException))]
        public void AddOrder3()
        {
            OrderService orderService = new OrderService();
            Order order = new Order(1, "Tom");
            Goods goods = new Goods("milk", 20);
            OrderDetails orderDetails = new OrderDetails(1, goods);
            order.AddOrderDetail(orderDetails);
            orderService.AddOrder(order);
            orderService.AddOrder(order);
        }
        [TestMethod]
        public void DeleteOrder1()
        {
            OrderService orderService = new OrderService();
            Order order = new Order(1, "Tom");
            Goods goods = new Goods("milk", 20);
            OrderDetails orderDetails = new OrderDetails(1, goods);
            order.AddOrderDetail(orderDetails);
            orderService.AddOrder(order);
            orderService.DeleteOrder(order);
            Assert.IsNull(orderService.GetById(1));
        }
        [TestMethod]
        public void DeleteOrder2()
        {
            OrderService orderService = new OrderService();
            Order order = new Order(1, "Tom");
            Goods goods = new Goods("milk", 20);
            OrderDetails orderDetails = new OrderDetails(1, goods);
            order.AddOrderDetail(orderDetails);
            orderService.AddOrder(order);
            orderService.DeleteOrder(1);
            Assert.IsNull(orderService.GetById(1));
        }
        [TestMethod]
        public void GetById1()
        {
            OrderService orderService = new OrderService();
            Order order = new Order(1, "Tom");
            Goods goods = new Goods("milk", 20);
            OrderDetails orderDetails = new OrderDetails(1, goods);
            order.AddOrderDetail(orderDetails);
            orderService.AddOrder(order);
            Assert.AreEqual(order, orderService.GetById(1));
        }
        [TestMethod]
        public void GetBYId2()
        {
            OrderService orderService = new OrderService();
            Assert.IsNull(orderService.GetById(1));
        }
        [TestMethod]
        [ExpectedException(typeof(ApplicationException))]
        public void ReplaceOrder1()
        {
            OrderService orderService = new OrderService();
            orderService.ReplaceOrder(null);
        }
        [TestMethod]
        public void ReplaceOrder2()
        {
            OrderService orderService = new OrderService();
            Order order = new Order(1, "Tom");
            Goods goods = new Goods("milk", 20);
            OrderDetails orderDetails = new OrderDetails(1, goods);
            order.AddOrderDetail(orderDetails);
            orderService.AddOrder(order);
            OrderService orderService2 = new OrderService();
            Order order2 = new Order(1, "Jack");
            Goods goods2 = new Goods("cow", 20);
            OrderDetails orderDetails2 = new OrderDetails(1, goods2);
            order2.AddOrderDetail(orderDetails2);
            orderService2.ReplaceOrder(order2);
            Assert.AreEqual(order2, orderService.GetById(1));
        }
        [TestMethod]
        public void ImportAndExport1()
        {
            OrderService orderService = new OrderService();
            orderService.Export();
            orderService.Import();
            Assert.AreEqual(0, orderService.GetOrders().Count);
        }
        [TestMethod]
        public void ImportAndExport2()
        {
            OrderService orderService = new OrderService();
            Order order = new Order(1, "Tom");
            Goods goods = new Goods("milk", 20);
            OrderDetails orderDetails = new OrderDetails(1, goods);
            order.AddOrderDetail(orderDetails);
            orderService.AddOrder(order);
            orderService.Export();
            orderService.DeleteOrder(order);
            orderService.Import();
            Assert.AreEqual(order, orderService.GetById(1));
        }
    }
}