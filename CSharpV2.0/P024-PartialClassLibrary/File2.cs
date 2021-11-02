using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P024_PartialClassLibrary
{
    public partial class Product
    {
        private double _cost;

        public double Cost
        {
            set
            {
                _cost = value;
            }
            get
            {
                return _cost;
            }
        }
    }
}
