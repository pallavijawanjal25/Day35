using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Linq_Product_Review_Management
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to review product management problem");

            List<ProductReview> productReviewList = new List<ProductReview>()
            {
                new ProductReview(){ProductID=1,UserID=1,Rating=2,Reviews="Good",IsLike=true},
                new ProductReview(){ProductID=2,UserID=2,Rating=4,Reviews="Good",IsLike=true},
                new ProductReview(){ProductID=3,UserID=1,Rating=5,Reviews="Good",IsLike=true},
                new ProductReview(){ProductID=4,UserID=2,Rating=6,Reviews="Good",IsLike=false},
                new ProductReview(){ProductID=5,UserID=3,Rating=2,Reviews="nice",IsLike=true},
                new ProductReview(){ProductID=6,UserID=4,Rating=1,Reviews="bad",IsLike=true},
                new ProductReview(){ProductID=7,UserID=5,Rating=1,Reviews="Good",IsLike=false},
                new ProductReview(){ProductID=7,UserID=3,Rating=9,Reviews="nice",IsLike=true},
                new ProductReview(){ProductID=9,UserID=7,Rating=7,Reviews="nice",IsLike=true},
                new ProductReview(){ProductID=10,UserID=7,Rating=7,Reviews="nice",IsLike=true},
                new ProductReview(){ProductID=11,UserID=10,Rating=5,Reviews="nice",IsLike=false},
                new ProductReview(){ProductID=12,UserID=12,Rating=6,Reviews="nice",IsLike=true},
                new ProductReview(){ProductID=13,UserID=12,Rating=7,Reviews="nice",IsLike=true},
                new ProductReview(){ProductID=14,UserID=14,Rating=7,Reviews="nice",IsLike=false},
                new ProductReview(){ProductID=14,UserID=14,Rating=7,Reviews="nice",IsLike=true},
                new ProductReview(){ProductID=16,UserID=17,Rating=7,Reviews="nice",IsLike=true},
                new ProductReview(){ProductID=17,UserID=17,Rating=7,Reviews="nice",IsLike=true},
                new ProductReview(){ProductID=18,UserID=19,Rating=9,Reviews="bad",IsLike=true},
                new ProductReview(){ProductID=19,UserID=20,Rating=9,Reviews="nice",IsLike=true},
                new ProductReview(){ProductID=20,UserID=25,Rating=7,Reviews="nice",IsLike=true},
                new ProductReview(){ProductID=21,UserID=20,Rating=7,Reviews="bad",IsLike=false},
                new ProductReview(){ProductID=22,UserID=21,Rating=10,Reviews="nice",IsLike=true},
                new ProductReview(){ProductID=23,UserID=20,Rating=9,Reviews="nice",IsLike=true},
                new ProductReview(){ProductID=25,UserID=25,Rating=9,Reviews="nice",IsLike=true},
                new ProductReview(){ProductID=25,UserID=20,Rating=6,Reviews="Good",IsLike=false},
                new ProductReview(){ProductID=17,UserID=17,Rating=11,Reviews="nice",IsLike=true},
            };
            //UC1
            /*foreach (var list in productReviewList)
            {
                 Console.WriteLine("ProductID : " + list.ProductID + " UserID : " + list.UserID + " Rating : " + list.Rating
                       + " Review : " + list.Reviews + " isLike : " + list.IsLike);
            }*/
            //UC2
            Management management = new Management();
            // management.TopRecords(productReviewList);
            //uc3
            //management.SelectRecords(productReviewList);
            //UC4
            // management.RetrieveCountofRecords(productReviewList);
            //UC5
            //management.RetrieveProductIDandReviews(productReviewList);
            //uc6
            //management.SkipTopFiveRecords(productReviewList);
            //UC8
            ProductReviewDatatable reviewDatatable = new ProductReviewDatatable();
            //DataTable table = reviewDatatable.AddDatatable();
            //reviewDatatable.DisplayProductReview(table);
            //UC10
            reviewDatatable.AverageProductRatings();




        }
    }
}