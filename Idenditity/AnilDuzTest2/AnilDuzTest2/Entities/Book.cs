using System;
using System.ComponentModel.DataAnnotations;

namespace AnilDuzTest2.Entities
{
    public class Book
    {
        
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Author { get; set; }
        public int Page { get; set; }
        public string Year { get; set; }


    }
}
