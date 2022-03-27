using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderTest
{
    [Serializable]
    public class OrderDetails
    {
        public OrderDetails(int numOfGoods, Goods goods)
        {
            NumOfGoods = numOfGoods;
            Goods = goods;
        }

        public int NumOfGoods { get; set; }
        public Goods Goods { get; set; }
        public override string ToString()
        {
            return "Name of goods:" + Goods.GoodsName + ",price of goods:" + Goods.GoodsPrice +
                ", number of goods:" + NumOfGoods;
        }
    }
}
