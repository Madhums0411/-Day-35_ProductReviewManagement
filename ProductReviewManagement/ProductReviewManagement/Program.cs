using ProductReviewManagementLINQ;
// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Welcome to Product Review Management Problem");


Console.WriteLine("Welcome To Product Review Management System");
List<ProductReview> list = ProductReviewManagement.AddProductsReview();
ProductReviewManagement.DisplayeProductsReview(list);
Console.ReadLine();