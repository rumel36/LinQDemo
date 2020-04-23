using System;
using System.Linq;

namespace LinQDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepo().GetBooks();
            //var cheapbooks = from b in books
            //                 where b.Price < 10
            //                 orderby b.Title
            //                 select b;
            //var cheapbooks = books
            //                    .Where(b => b.Price < 10)
            //                    .OrderBy(b=>b.Title)
            //                    .Select(b=>b.Title);

            //foreach(var book in cheapbooks)
            //   //Console.WriteLine(book.Title+" "+book.Price);
            //   Console.WriteLine(book.Title);
            //var book = books.SingleOrDefault(b => b.Title == "ASP.NET MVC++");
            //var book = books.Single(b => b.Title == "ASP.NET MVC++");
            //var maxPrice = books.Max(b => b.Price);
            //var minPrice = books.Min(b => b.Price);
            //var avg = books.Average(b => b.Price);
            int a = 5, b = 4;
            Action action = () => Console.WriteLine(a * b);
            action();
            Func<int, int> f  = b => b * b;
            //Console.WriteLine(maxPrice +" "+ minPrice +" "+ avg);
            Console.WriteLine(f(2));

            Action<int> ac = b =>Console.WriteLine( b * b);
            //Console.WriteLine(maxPrice +" "+ minPrice +" "+ avg);
            Console.WriteLine(f(2));

        }
    }
}
