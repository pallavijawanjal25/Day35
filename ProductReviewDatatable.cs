using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Linq_Product_Review_Management
{
    class ProductReviewDatatable
    {
        public DataTable AddDatatable()
        {
            DataTable table = new DataTable();

            table.Columns.Add("ProductID");
            table.Columns.Add("UserID");
            table.Columns.Add("Rating");
            table.Columns.Add("Review");
            table.Columns.Add("isLike");

            table.Rows.Add(1, 1, 2, "good", false);
            table.Rows.Add(2, 1, 4, "good", true);
            table.Rows.Add(1, 2, 5, "bad", false);
            table.Rows.Add(4, 2, 6, "good", true);
            table.Rows.Add(5, 3, 2, "nice", false);
            table.Rows.Add(6, 4, 1, "bad", false);
            table.Rows.Add(7, 4, 1.5, "nice", true);
            table.Rows.Add(8, 3, 1.5, "nice", false);
            table.Rows.Add(9, 3, 3.5, "good", false);
            table.Rows.Add(11, 10, 9, "nice", true);
            table.Rows.Add(10, 10, 4, "nice", false);
            table.Rows.Add(2, 10, 4, "good", false);
            table.Rows.Add(13, 10, 4, "nice", true);
            table.Rows.Add(4, 10, 4, "nice", true);
            table.Rows.Add(15, 10, 4, "nice", true);
            table.Rows.Add(16, 10, 4, "nice", true);
            table.Rows.Add(20, 3, 1, "bad", true);
            return table;


        }
        public void DisplayProductReview(DataTable table)
        {
            //var products = from product in table.AsEnumerable() select product.Field<ProductReview>("ProductID","UserID", "Rating", "Review", "isLike");
            DataRow[] records = table.Select();
            for (int i = 0; i < records.Length; i++)
            {
                Console.WriteLine("product id :" + records[i][0] + " User id: " + records[i][1] + " Rating :" + records[i][2] +
                    " Review :" + records[i][3] + " isLike :" + records[i][4]);
            }
        }
        public void AverageProductRatings()
        {
            DataTable table = new DataTable();
            var averageRecords = table.AsEnumerable().GroupBy(x => x.Field<int>("ProductID")).Select(x => new { ProductID = x.Key, Average = x.Average(m => m.Field<double>("Rating")) });
            foreach (var dataItem in averageRecords)
            {
                Console.WriteLine("Product Id :" + dataItem.ProductID + " Average Rating :" + dataItem.Average);
            }
        }
    }
}