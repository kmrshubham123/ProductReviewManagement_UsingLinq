using System;
using System.Collections.Generic;
using System.Data;

namespace ProductReviewManagementWithLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****Welcome to product review Management****");
            Console.WriteLine("=====================================================================");
            //UC1:-Create variable for list of product Review  and Add 25 default values in list
            List<ProductReview> productReviewList = new List<ProductReview>()
            {
                new ProductReview(){ProductID=1,UserID=1,Rating=9,Review="Good",isLike=true},
                new ProductReview(){ProductID=2,UserID=3,Rating=8,Review="Good",isLike=true},
                new ProductReview(){ProductID=3,UserID=2,Rating=5,Review="Good",isLike=true},
                new ProductReview(){ProductID=4,UserID=2,Rating=4,Review="Good",isLike=true},
                new ProductReview(){ProductID=5,UserID=3,Rating=2,Review="nice",isLike=false},
                new ProductReview(){ProductID=6,UserID=4,Rating=1,Review="Bad",isLike=false},
                new ProductReview(){ProductID=7,UserID=3,Rating=3.5,Review="nice",isLike=false},
                new ProductReview(){ProductID=8,UserID=3,Rating=3.5,Review="nice",isLike=false},
                new ProductReview(){ProductID=9,UserID=3,Rating=3.5,Review="nice",isLike=false},
                new ProductReview(){ProductID=10,UserID=3,Rating=3.5,Review="nice",isLike=false},
                new ProductReview(){ProductID=11,UserID=3,Rating=3.5,Review="nice",isLike=false},
                new ProductReview(){ProductID=12,UserID=10,Rating=3,Review="nice",isLike=true},
                new ProductReview(){ProductID=13,UserID=18,Rating=3,Review="nice",isLike=true},
                new ProductReview(){ProductID=14,UserID=10,Rating=2,Review="Bad",isLike=true},
                new ProductReview(){ProductID=15,UserID=19,Rating=3,Review="nice",isLike=true},
                new ProductReview(){ProductID=16,UserID=10,Rating=3.5,Review="nice",isLike=true},
                new ProductReview(){ProductID=17,UserID=10,Rating=3.2,Review="nice",isLike=true},
                new ProductReview(){ProductID=18,UserID=15,Rating=3.5,Review="nice",isLike=true},
                new ProductReview(){ProductID=19,UserID=3,Rating=3.5,Review="nice",isLike=false},
                new ProductReview(){ProductID=20,UserID=13,Rating=3.5,Review="nice",isLike=false},
                new ProductReview(){ProductID=21,UserID=23,Rating=3.5,Review="nice",isLike=false},
                new ProductReview(){ProductID=22,UserID=10,Rating=3,Review="nice",isLike=true},
                new ProductReview(){ProductID=23,UserID=10,Rating=3,Review="nice",isLike=true},
                new ProductReview(){ProductID=24,UserID=10,Rating=2,Review="Bad",isLike=true},
                new ProductReview(){ProductID=25,UserID=2,Rating=10,Review="Good",isLike=true},
            };
            //print the list
            //foreach (var list in productReviewList)
            //{
            //    Console.WriteLine("ProductID:-" + list.ProductID + " " + "UserID:-" + list.UserID
            //        + " " + "Rating:-" + list.Rating + " " + "Review:-" + list.Review + " " + "isLike:-" + list.isLike);
            //}
            //UC2:-Retrieve Top 3 records from the list who's rating is high 
            Management management = new Management();
            management.TopRecords(productReviewList);
            Console.WriteLine("=========================================");
            //UC3:- Retrieve record from the list,rating > 3 and product ID is 1,4,9
            management.SelectedRecords(productReviewList);
            //UC4:-Count of review present for each productID
            Console.WriteLine("======================COUNT===================");
            management.RetrieveCountOfRecords(productReviewList);
            //UC5:-Reterive Only ProductID and review
            Console.WriteLine("============ Reterive Only ProductID and review ===============");
            management.RetrieveOnlyProductIdAndReview(productReviewList);
            // UC6:-Skip top 5 records from the list
            Console.WriteLine("===============================================");
            management.SkipTopFiveRecords(productReviewList);
            //UC7:-Retrive ProductID and review from the list
            Console.WriteLine("===============================================");
            management.SelectIdAndReview(productReviewList);
            //UC9:-Reterive all the record from the dataTable variable who's Like value is true
            Console.WriteLine("=================================================");
            DataTableOperation dataTable = new DataTableOperation();
            DataTable table = dataTable.CreateDataTable();
            dataTable.DisplayIsLikeValueTrue(table);

        }
    }
}
