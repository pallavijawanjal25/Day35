using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Linq;

namespace Linq_Product_Review_Management
{
    public class Management
    {
        public readonly DataTable dataTable = new DataTable();

        public void TopRecords(List<ProductReview> listproductReview)
        {
            var recordData = (from productReviews in listproductReview
                              orderby productReviews.Rating descending
                              select productReviews).Take(3);

            foreach (var list in recordData)
            {
                Console.WriteLine("ProductID : " + list.ProductID + " UserID : " + list.UserID + " Rating : " + list.Rating
                   + " Review : " + list.Reviews + " isLike : " + list.IsLike);
            }
        }
        public void SelectRecords(List<ProductReview> listproductReview)
        {
            var recordData = (from ProductReview in listproductReview
                              where (ProductReview.ProductID == 1 || ProductReview.ProductID == 4 || ProductReview.ProductID == 9) && ProductReview.Rating > 3
                              select ProductReview);

            foreach (var list in recordData)
            {
                Console.WriteLine("ProductID : " + list.ProductID + " UserID : " + list.UserID + " Rating : " + list.Rating
                   + " Review : " + list.Reviews + " isLike : " + list.IsLike);

            }
        }
        public void RetrieveCountofRecords(List<ProductReview> productReviews)
        {
            var recordCount = productReviews.GroupBy(x => x.ProductID)
              .Select(x => new { ProductID = x.Key, Count = x.Count() });

            foreach (var list in recordCount)
            {
                Console.WriteLine("ProductID : " + list.ProductID + " Count : " + list.Count);

            }
        }
        public void RetrieveProductIDandReviews(List<ProductReview> listproductReviews)
        {
            var records = from ProductReview in listproductReviews select (ProductReview.ProductID, ProductReview.Reviews);

            foreach (var list in records)
            {
                Console.WriteLine("ProductId : " + list.ProductID + "Reviews : " + list.Reviews);
            }
        }
        public void SkipTopFiveRecords(List<ProductReview> productReviews)
        {
            var skiprecords = (from product in productReviews select product).Skip(5);

            foreach (var list in skiprecords)
            {
                Console.WriteLine("ProductID : " + list.ProductID + " UserID : " + list.UserID + " Rating : " + list.Rating
                    + " Review : " + list.Reviews + " isLike : " + list.IsLike);
            }
        }
        public void FetchNice(List<ProductReview> productReviews)
        {
            var fetchrecords = from product in productReviews select (productReviews);
        }


    }
}