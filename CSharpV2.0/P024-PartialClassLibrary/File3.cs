using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P024_PartialClassLibrary
{
    public partial class Product
    {
        public double GetTax()
        {
            double tax = Cost * 14 / 100;
            return tax;
        }
    }
}
