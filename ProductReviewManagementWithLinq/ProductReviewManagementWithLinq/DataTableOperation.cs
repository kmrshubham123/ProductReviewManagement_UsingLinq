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
            table.Columns.Add("ProductID" ,typeof(int)) ;
            table.Columns.Add("UserID",typeof(int));
            table.Columns.Add("Rating",typeof(float));
            table.Columns.Add("Review",typeof(string));
            table.Columns.Add("IsLike",typeof(bool));

            table.Rows.Add(1, 1, 5, "Good", true);
            table.Rows.Add(2, 6, 8, "Good", true);
            table.Rows.Add(3, 10, 5, "Good", true);
            table.Rows.Add(4, 5, 6, "Good", false);
            table.Rows.Add(5, 12, 2, "nice", true);
            table.Rows.Add(6, 19, 1, "bad", true);
            table.Rows.Add(7, 190, 1, "Good", false);
            table.Rows.Add(8, 123, 9, "nice", true);
            table.Rows.Add(9, 132, 10, "nice", true);
            table.Rows.Add(10, 179, 8, "nice", true);
            table.Rows.Add(11, 113, 3.5, "nice", true);
            table.Rows.Add(12, 111, 2, "Good", true);
            table.Rows.Add(13, 139, 4, "Good", true);
            table.Rows.Add(14, 116, 5, "Good", true);
            table.Rows.Add(15, 12, 6.2, "Good", false);
            table.Rows.Add(16, 19, 2, "nice", true);
            table.Rows.Add(17, 17, 1.6, "bad", true);
            table.Rows.Add(18, 169, 1, "bad", false);
            table.Rows.Add(19, 112, 9, "nice", true);
            table.Rows.Add(20, 116, 10, "nice", true);
            table.Rows.Add(21, 189, 8, "Good", true);
            table.Rows.Add(22, 113, 3, "nice", true);
            table.Rows.Add(23, 114, 5, "Good", true);
            table.Rows.Add(24, 136, 6, "Good", false);
            table.Rows.Add(25, 179, 2, "bad", true);
            return table;
        }     
        public void DisplayIsLikeValueTrue(DataTable table)
        {
            var records = from products in table.AsEnumerable().Where(x => x["isLike"].Equals(true)) select products;

            Console.WriteLine("List of IsLike value in Data");
            foreach (var product in records)
            {
                Console.WriteLine("ProductID : " + product.Field<int>("ProductID") + " " + "UserID : " + product.Field<int>("UserID") + " " + "Rating : " + product.Field<float>("Rating") + " " + "Review : " + product.Field<string>("Review") + " " + "IsLike : " + product.Field<bool>("IsLike") + " ");
             
            }
        }
    }
}
