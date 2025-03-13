using Domain.Products.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Products.Bascket
{
    class ProductToBascketModel
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public string Name { get; set; }
        public ProductStatus Status { get; set; }


    }
}
