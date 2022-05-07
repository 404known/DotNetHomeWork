using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderTest
{
    [Serializable]
    public class OrderDetails
    {
        public OrderDetails()
        {

        }
        public OrderDetails(int numOfGoods, Goods goods)
        {
            NumOfGoods = numOfGoods;
            Goods = goods;
        }
        public int OrderDetailsId { get; set; }

        [NotMapped]
        public String GoodName { get =>Goods == null? "Nothing" : Goods.GoodsName; }

        [NotMapped]
        public double GoodsPrice { get => Goods == null? 0 : Goods.GoodsPrice; }
        public int NumOfGoods { get; set; }
                
        public Goods Goods { get; set; }
        public override string ToString()
        {
            return "Name of goods:" + Goods.GoodsName + ",price of goods:" + Goods.GoodsPrice +
                ", number of goods:" + NumOfGoods;
        }
    }
}
