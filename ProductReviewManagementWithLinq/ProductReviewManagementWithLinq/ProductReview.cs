using System;
using System.Collections.Generic;
using System.Text;

namespace ProductReviewManagementWithLinq
{
    /// <summary>
    /// UC1:-Create a Product review class with ProductID,UserID,Rating,Review and isLike field
    /// </summary>
    public class ProductReview 
    {
        public int ProductID { get; set; }
        public int UserID { get; set; }
        public double Rating { get; set; }
        public string Review { get; set; }
        public bool isLike { get; set; }

    }
}
