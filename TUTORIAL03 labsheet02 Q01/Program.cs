using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUTORIAL03 
{
    public class program
    {
        public static void Main()
        {
            Book book = new Book();
            book.Author = "Martin Wickamasighe";
            book.Title = "Madol Duwa";

            Console.WriteLine(book.Title);
            Console.WriteLine(book.Author);
            Console.ReadLine();
        }
    }
}