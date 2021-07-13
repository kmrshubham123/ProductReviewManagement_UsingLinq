using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ProductReviewManagementWithLinq
{
    public class DataTableOperation
    {
        /// <summary>
        /// UC8:-Create DataTable using c# and Add productID,UserID,Rating,Review and isLike field
        /// </summary>
        public void CreateDataTable()
        {
            DataTable table = new DataTable();
            table.Columns.Add("ProductID");
            table.Columns.Add("UserID");
            table.Columns.Add("Rating");
            table.Columns.Add("Review");
            table.Columns.Add("IsLike");

            table.Rows.Add(1, 1, 5, "Good", true);
            table.Rows.Add(2, 1, 8, "Good", true);
            table.Rows.Add(3, 1, 5, "Good", true);
            table.Rows.Add(4, 1, 6, "Good", false);
            table.Rows.Add(5, 1, 2, "nice", true);
            table.Rows.Add(6, 1, 1, "bad", true);
            table.Rows.Add(7, 1, 1, "Good", false);
            table.Rows.Add(8, 1, 9, "nice", true);
            table.Rows.Add(9, 1, 10, "nice", true);
            table.Rows.Add(10, 1, 8, "nice", true);
            table.Rows.Add(11, 1, 3, "nice", true);
            table.Rows.Add(12, 1, 2, "Good", true);
            table.Rows.Add(13, 1, 4, "Good", true);
            table.Rows.Add(14, 1, 5, "Good", true);
            table.Rows.Add(15, 1, 6, "Good", false);
            table.Rows.Add(16, 1, 2, "nice", true);
            table.Rows.Add(17, 1, 1, "bad", true);
            table.Rows.Add(18, 1, 1, "bad", false);
            table.Rows.Add(19, 1, 9, "nice", true);
            table.Rows.Add(20, 1, 10, "nice", true);
            table.Rows.Add(21, 1, 8, "Good", true);
            table.Rows.Add(22, 1, 3, "nice", true);
            table.Rows.Add(23, 1, 5, "Good", true);
            table.Rows.Add(24, 1, 6, "Good", false);
            table.Rows.Add(25, 1, 2, "bad", true);
        }
    }
}
