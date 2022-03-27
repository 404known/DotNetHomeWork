using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderTest
{
    [Serializable]
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
            return "Name of Goods:" + GoodsName + " Price:" + GoodsPrice;
        }
    }

}
