using System;
using System.Collections.Generic;
using System.Text;

namespace Linq_Product_Review_Management
{
    public class ProductReview
    {
        public int ProductID { get; set; }
        public int UserID { get; set; }
        public double Rating { get; set; }
        public string Reviews { get; set; }
        public bool IsLike { get; set; }
    }
}