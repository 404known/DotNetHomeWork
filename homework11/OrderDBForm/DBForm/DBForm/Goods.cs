using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderTest
{
    [Serializable]
    public class Goods
    {
        public Goods()
        {

        }
        public Goods(string goodsName, double goodsPrice)
        {
            GoodsName = goodsName;
            GoodsPrice = goodsPrice;
        }
        [Key]
        public int GoodsId { get; set; }
        public string GoodsName { get; set; }
        public double GoodsPrice { get; set; }
        public override string ToString()
        {
            return "Name of Goods:" + GoodsName + " Price:" + GoodsPrice;
        }
    }

}
