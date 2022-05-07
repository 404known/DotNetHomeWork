using Microsoft.EntityFrameworkCore;
using OrderTest;

namespace OrderAPI.Models
{
    public class OrderContext : DbContext
    {
        public OrderContext(DbContextOptions<OrderContext> options)
            : base(options)
        {
            this.Database.EnsureCreated(); //自动建库建表
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails> orderDetails { get; set; }
        public DbSet<Goods> goods { get; set; }
    }
}
