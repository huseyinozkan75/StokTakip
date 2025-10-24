namespace StokTakipEntityFrameWork
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Products
    {
        public long Id { get; set; }

        [Required]
        [StringLength(100)]
        public string ProductName { get; set; }

        public bool Status { get; set; }

        public DateTime CreateDate { get; set; }

        public decimal Price { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        public int StocksCount { get; set; }

        public long CategoryID { get; set; }

        public long BrandID { get; set; }

        public virtual Brands Brands { get; set; }

        public virtual Categories Categories { get; set; }
    }
}
