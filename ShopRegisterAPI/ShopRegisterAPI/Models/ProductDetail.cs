using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShopRegisterAPI.Models {
    public class ProductDetail {
        [Key]
        public int ProductId { get; set; }

        [Column(TypeName ="nvarchar(100)")]
        public string ProductName { get; set; }

        [Column(TypeName ="varchar=10")]
        public string ProductCode { get; set; }

        [Column(TypeName ="varchar=5")]
        public string ProductRegisterDate { get; set; }

        [Column(TypeName ="varchar=100000")]
        public long ProductPrice { get; set; }
    }
}
