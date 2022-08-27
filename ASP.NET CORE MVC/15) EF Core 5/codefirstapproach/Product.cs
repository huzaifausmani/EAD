using System.IO;
using System;

namespace codefirstapproach
{
    public class Product
    {
        public int ID { get; set; }         //EF will create primary key against this prop in db.
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}