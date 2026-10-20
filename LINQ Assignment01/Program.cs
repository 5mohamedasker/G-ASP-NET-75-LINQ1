using LINQ.DataSources;
using LINQ.Models;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Globalization;
using System.Xml.Linq;
using static LINQ.DataSources.Source;

namespace LINQ_Assignment01
{
    internal class Program
    {
        static void Main()
        {
            // Question 1
            // Get all products from the "Seafood" category.
            // Print each product's name and price.


            //   var result = ProductList.Where(P => P.Category == "Seafood").Select(P => new { P.ProductName  , P.UnitPrice} );
            //   foreach (var item in result)
            //   {
            //       Console.WriteLine(item);
            //   }





            // Question 2
            // Get a list of only the product names from ProductList.
            // Print each name.


            //    var result = ProductList.Select(n => n.ProductName);
            //    foreach (var item in result)
            //    {
            //         Console.WriteLine(item);
            //    }





            // Question 3
            // Sort all products by UnitPrice(ascending). 
            // Print each product's name and price.


            //    var result = ProductList.Select(P =>new { P.ProductName, P.UnitPrice }).OrderBy(P => P.UnitPrice);
            //    foreach (var item in result)
            //    {
            //        Console.WriteLine(item);
            //    }





            // Question 4
            // Get all products where UnitPrice is between 10 and 30


            //    var result = ProductList.Select(P => P).Where(P => P.UnitPrice>10 && P.UnitPrice<20 );
            //    foreach (var item in result)
            //    {
            //        Console.WriteLine(item);
            //    }





            // Question 5
            // Get all products that are in stock(UnitsInStock > 0) and
            // belong to the "Condiments" category.


            //    var result = ProductList.Select(P => P).Where(P => P.UnitsInStock > 0 && P.Category == "Condiments");
            //    foreach (var item in result)
            //    {
            //        Console.WriteLine(item);
            //    }





            // Question 6
            // Create a new anonymous type with three properties:
            //   ● Name → the product name
            //   ● Price → the unit price
            //   ● StockStatus → a string: "Available" if UnitsInStock > 0, otherwise "Out of Stock"
            //   ● Print the result.


            //    var result = ProductList.Select(P => new
            //                                            {
            //                                                Name = P.ProductName,
            //                                                Price = P.UnitPrice,
            //                                                StockStatuse = P.UnitsInStock > 0 ? "Available" : "Out of Stock"
            //                                            });
            //    foreach (var item in result)
            //    {
            //        Console.WriteLine(item);
            //    }





            // Question 7
            // Print each product's name along with its position (1-based) in the list.
            // Expected format: 1.Chai, 2.Chang, etc.


            //    var result = ProductList.Select((P, i) => $"{i + 1}. {P.ProductName}");
            //    foreach (var item in result)
            //    {
            //        Console.WriteLine(item);
            //    }





            // Question 8 
            // Sort ProductList by Category ascending, then within each
            // category, sort by UnitPrice descending.


            //    var result = ProductList.OrderBy(P => P.Category).ThenByDescending(P => P.UnitPrice);
            //    foreach (var item in result)
            //    {
            //        Console.WriteLine(item);
            //    }





            // Question 9
            // Get all products from the "Beverages" category, sorted by
            // UnitsInStock descending. Print name and stock.


            //    var result = ProductList.Where(P => P.Category == "Beverages")
            //                            .OrderByDescending(P => P.UnitsInStock)
            //                            .Select(P => new { P.ProductName, P.UnitsInStock });
            //    foreach (var item in result)
            //    {
            //        Console.WriteLine(item);
            //    }





            // Question 10
            // Using QUERY SYNTAX with a compound from clause, list
            // all orders placed in 1997 or later showing CustomerID and
            // OrderDate.


            //    var result = from C in CustomerList
            //                 from O in C.Orders
            //                 where O.OrderDate > new DateTime(1997,1,1)
            //                 select new { C.CustomerID, O.OrderDate };
            //    foreach (var item in result)
            //    {
            //        Console.WriteLine(item);
            //    }





            // Question 11
            // Show position number alongside ProductName


            //    var result = ProductList.Select((P,i)=> $"{i+1} - {P.ProductName}" );
            //    foreach (var item in result)
            //    {
            //        Console.WriteLine(item);
            //    }





            // Question 12
            // Sort first by-word length and then by a
            // case -insensitive sort of the words in an array.
            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };


            //    var result = Arr.OrderBy(x => x.Length).ThenBy(x => x, StringComparer.OrdinalIgnoreCase);
            //    foreach (var item in result)
            //    {
            //        Console.WriteLine(item);
            //    }





            // Question 13
            // Create a list of all digits in the array whose second
            // letter is 'i' that is reversed from the order in the
            // original array.


            //    var result = Arr.Where((A, i) => A[1] == 'i'  ).Reverse();
            //    foreach (var item in result)
            //    {
            //        Console.WriteLine(item);
            //    }
        }
    }
}
