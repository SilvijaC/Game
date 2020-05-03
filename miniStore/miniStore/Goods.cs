using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace miniStore
{
    public class Goods 
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Goods(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }

        public override string ToString()
        {
            return Name + ' ' + Price + " EUR";
        }
    }
}
