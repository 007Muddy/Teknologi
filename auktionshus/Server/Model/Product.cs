using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Model
{
    public class Product
    {

        public int Id { get; set; }

        public decimal MinPrice { get; set; }
        public decimal SalePrice { get; set; }

        public int AuktionTime { get; set; }

        public DateTime EndTime
        {
            get
            {
                return DateTime.Now.AddSeconds(AuktionTime*60);
            }

        }

        public Product(int id, Decimal minPrice, Decimal salePrice)
        
        {
        Id = id;
            MinPrice = minPrice;    
            SalePrice = salePrice;  
        
        }

    }
}
