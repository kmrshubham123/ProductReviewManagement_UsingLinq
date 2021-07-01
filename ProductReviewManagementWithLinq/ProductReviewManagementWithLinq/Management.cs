using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Linq;

namespace ProductReviewManagementWithLinq
{
    public class Management
    {
        /// <summary>
        /// UC2:-Create a method to Pick Top 3 Records from the list
        /// </summary>
        /// <param name="review"></param>
        public void TopRecords(List<ProductReview> review)
        {

            var recordedData = (from productReviews in review
                                orderby productReviews.Rating descending //This query give me highest rating to Lowest Rating
                                select productReviews).Take(3); //linq operator "Take" 3 records in descending order
            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductID:-" + list.ProductID + " " + "UserID:-" + list.UserID
                    + " " + "Rating:-" + list.Rating + " " + "Review:-" + list.Review + " " + "isLike:-" + list.isLike);
            }
        }
    }
}
