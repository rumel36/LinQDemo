using System;
using System.Collections.Generic;
using System.Text;

namespace LinQDemo
{
    public class BookRepo
    {
        public IEnumerable<Book> GetBooks() {
            return new List<Book>
            {
                new Book(){ Title = "ASP.net", Price = 10},
                new Book(){ Title = "XML beginner", Price = 5 },
                new Book(){ Title = "C#.net", Price = 8 },
                new Book(){ Title = "ASP.net", Price = 7 },
                new Book(){ Title = "Java Enterprise", Price = 10 }
                
            };
        }
    }
}
