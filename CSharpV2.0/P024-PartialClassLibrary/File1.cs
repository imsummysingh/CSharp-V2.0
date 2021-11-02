using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P024_PartialClassLibrary
{
    public partial class Product
    {
        private int _productId;

        public int ProductId
        {
            set
            {
                _productId = value;
            }
            get
            {
                return _productId;
            }
        }
    }
}
