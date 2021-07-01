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
        /// <summary>
        /// UC3:-method is use to Retrieve record from the list,rating > 3 and product ID is 1,4,9
        /// </summary>
        /// <param name="review"></param>
        public void SelectedRecords(List<ProductReview> review)
        {
            var recordedData = from productReviews in review
                               where (productReviews.ProductID == 1 || productReviews.ProductID == 4 || productReviews.ProductID == 9) 
                               && productReviews.Rating > 3
                               select productReviews;
            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductID:-" + list.ProductID + " " + "UserID:-" + list.UserID
                    + " " + "Rating:-" + list.Rating + " " + "Review:-" + list.Review + " " + "isLike:-" + list.isLike);
            }
        }
        /// <summary>
        /// UC4:-Reterive Count of review present for each productID
        /// </summary>
        /// <param name="review"></param>
        public void RetrieveCountOfRecords(List<ProductReview> review)
        {
            //Groupby:-Group the element of a sequence according to a specified key selector function
            //Select:-Projects Each element of a sequence into a new form
            var recordedData = review.GroupBy(x => x.ProductID).Select(x => new { ProductID = x.Key, Count = x.Count() });
            foreach (var list in recordedData)
            {
                Console.WriteLine(list.ProductID + "==>" + list.Count);
            }
        }
        /// <summary>
        /// Reterive only ProductID and review from the list of all records
        /// </summary>
        /// <param name="review"></param>
        public void RetrieveOnlyProductIdAndReview(List<ProductReview> review)
        {
            var recordedData = from productReviews in review
                               select new { productReviews.ProductID, productReviews.Review };
            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductID:-" + list.ProductID + " " + "Review:-" + list.Review);
            }
        }
        /// <summary>
        /// UC6:-Skip top 5 records from the list
        /// </summary>
        /// <param name="review"></param>
        public void SkipTopFiveRecords(List<ProductReview> review)
        {
            var recordedData = (from productReviews in review
                                select productReviews).Skip(5);
            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductID:-" + list.ProductID + " " + "UserID:-" + list.UserID
                    + " " + "Rating:-" + list.Rating + " " + "Review:-" + list.Review + " " + "isLike:-" + list.isLike);
            }
        }
    }
}
