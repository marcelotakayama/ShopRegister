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

        [Column(TypeName ="nvarchar(10)")]
        public string ProductCode { get; set; }

        [Column(TypeName ="nvarchar(5)")]
        public string ProductRegisterDate { get; set; }

        [Column(TypeName ="nvarchar(100)")]
        public decimal ProductPrice { get; set; }
    }
}
