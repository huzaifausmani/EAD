using System.Data.Common;
using System;
using System.Linq;
using codefirstapproach;



// namespace codefirstapproach
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
            

//         }
//     }
// }


Console.WriteLine("Hello World!");

var db = new ShoppingContext();

//--------------------------------Insert--------------------------------
// Product p = new Product();
// p.Name = "Cycle";
// p.Price = 2500;

// db.Products.Add(p);

// await db.SaveChangesAsync();    //await can only be used in asyn method

// Console.WriteLine($"Product id of the product recently added: {p.ID}");



//--------------------------------Select--------------------------------
// must have to add using System.Linq;
db.Products.Where(p => p.Name.StartsWith("S")).ToList()
    .ForEach(p => Console.WriteLine($"{p.ID}, {p.Name}, {p.Price}"));



//--------------------------------Update--------------------------------
// var p2 = db.Products.First();                 //returns first row of table.
// p2.Price = 50.0M;
// await db.SaveChangesAsync();



//--------------------------------Delete--------------------------------
// var p3 = db.Products.First(p => p.Name == "Bike");   //returns first row of table where Name = "Bike".
// db.Remove(p3);
// await db.SaveChangesAsync();