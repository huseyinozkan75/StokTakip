using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakipAdonet
{
    public class Product
    {
        public Int64 Id { get; set; }
        public string ProductName { get; set; }
        public bool Status { get; set; }
        public DateTime CreateDate { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int StocksCount { get; set; }
        public Int64 CategoryID { get; set; }
        public Int64 BrandID { get; set; }
    }
}
