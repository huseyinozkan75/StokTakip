using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakipAdonet
{
    public class Brand
    {
        public Int64 Id { get; set; }
        public string BrandName { get; set; }
        public string Desciption { get; set; }
        public bool Status { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
