using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ProductReviewManagementWithLinq
{
    public class DataTableOperation
    {
        /// <summary>
        /// UC8:-Create DataTable using c# and Add productID,UserID,Rating,Review and isLike field
        /// </summary>
        public DataTable CreateDataTable()
        {
            DataTable table = new DataTable();
            table.Columns.Add("ProductID", typeof(int));
            table.Columns.Add("UserID", typeof(int));
            table.Columns.Add("Rating", typeof(float));
            table.Columns.Add("Review", typeof(string));
            table.Columns.Add("IsLike", typeof(bool));

            table.Rows.Add(1, 1, 5, "Good", true);
            table.Rows.Add(2, 6, 8, "Good", true);
            table.Rows.Add(3, 10, 5, "Good", true);
            table.Rows.Add(4, 5, 6, "Good", false);
            table.Rows.Add(5, 12, 2, "nice", true);
            table.Rows.Add(6, 19, 1, "bad", true);
            table.Rows.Add(7, 10, 1, "Good", false);
            table.Rows.Add(8, 10, 9, "nice", true);
            table.Rows.Add(9, 132, 10, "nice", true);
            table.Rows.Add(10, 179, 8, "nice", true);
            table.Rows.Add(11, 10, 3.5, "nice", true);
            table.Rows.Add(12, 111, 2, "Good", true);
            table.Rows.Add(13, 139, 4, "Good", true);
            table.Rows.Add(14, 10, 5, "Good", true);
            table.Rows.Add(15, 12, 6.2, "Good", false);
            table.Rows.Add(16, 10, 2, "nice", true);
            table.Rows.Add(17, 17, 1.6, "bad", true);
            table.Rows.Add(18, 10, 1, "bad", false);
            table.Rows.Add(19, 10, 9, "nice", true);
            table.Rows.Add(20, 116, 10, "nice", true);
            table.Rows.Add(21, 189, 8, "Good", true);
            table.Rows.Add(22, 10, 3, "nice", true);
            table.Rows.Add(23, 114, 5, "Good", true);
            table.Rows.Add(24, 136, 6, "Good", false);
            table.Rows.Add(25, 179, 2, "bad", true);
            return table;
        }
        /// <summary>
        /// UC9:-Reterive all the record from the dataTable variable who's Like value is true
        /// </summary>
        /// <param name="table"></param>
        public void DisplayIsLikeValueTrue(DataTable table)
        {
            //To cast a specific type(DataTable) to its IEnumerable(interface with Linq query) equivalent, use the AsEnumerable() method,also it is an extension method.
            var records = from products in table.AsEnumerable().Where(x => x["isLike"].Equals(true)) select products;

            Console.WriteLine("List of IsLike value in Data");
            foreach (var product in records)
            {
                Console.WriteLine("ProductID : " + product.Field<int>("ProductID") + " " + "UserID : " + product.Field<int>("UserID") + " " + "Rating : " + product.Field<float>("Rating") + " " + "Review : " + product.Field<string>("Review") + " " + "IsLike : " + product.Field<bool>("IsLike") + " ");

            }
        }
        /// <summary>
        /// UC10:-Average Rating of Each ProductId
        /// </summary>
        /// <param name="dataTable"></param>
        public void AverageRatingProductID(DataTable dataTable)
        {
            var average = (from product in dataTable.AsEnumerable()
                           select (product.Field<float>("Rating"))).Average();   //Field:-Provides strongly-typed access to each of the column values in the specified row
            Console.WriteLine("Average Rating of productId " + average);
        }
        /// <summary>
        /// UC11:-Retreive all records from the list who's review message contain "nice"
        /// </summary>
        /// <param name="dataTable"></param>
        public void ReviewIsNice(DataTable dataTable)
        {
            var records = from product in dataTable.AsEnumerable().Where(x => x["Review"].ToString().Contains("nice")) select product;
            foreach (var product in records)
            {

                Console.WriteLine("ProductID : " + product.Field<int>("ProductID") + " " + "UserID : " + product.Field<int>("UserID") + " " + "Rating : " + product.Field<float>("Rating") + " " + "Review : " + product.Field<string>("Review") + " " + "IsLike : " + product.Field<bool>("IsLike"));

            }

        }
        /// <summary>
        ///UC12:-Reterive all the records from the list who's Userid is 10 and order by Rating
        /// </summary>
        /// <param name="table"></param>
        public void RetrievParticularUserID(DataTable datatable)
        {
            var records = from products in datatable.AsEnumerable()
                          .OrderBy(x => x["Rating"]) // Sorts the rows of a System.Data.EnumerableRowCollection in ascending order according to the specified key.

                          .Where(x => x["UserID"].Equals(10))
                          select products;
            Console.WriteLine("List Of Products whose UserID is 10 and order by Rating");
            foreach (var product in records)
            {
                Console.Write("ProductID : " + product.Field<int>("ProductID") + " " + "UserID : " + product.Field<int>("UserID")
                    + " " + "Rating : " + product.Field<float>("Rating") + " " + "Review : " + product.Field<string>("Review") + " " + "IsLike : " + product.Field<bool>("IsLike") + " ") ;
                Console.WriteLine("\n");
            }
        }

    }
}
