using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCalculator
{
    internal class SetVars
    {
        public string name;
        public float price;
        public float much;
        public float totalprice;
        public SetVars(string name, float price, float much)
        {
            this.much = much;
            this.price = price;
            if (name.Length <= 0) { this.name = "ali"; }
            else { this.name = name; }
            this.totalprice = much * price;
            



        }
        public SetVars()
        {
            this.much = 0;
            this.price = 0;
            this.name = " ";
        }
    }
}
