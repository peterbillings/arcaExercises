using System;

namespace Books
{
    class Program
    {
        static void Main(string[] args)
        {
            Bookshelf bookShelf125 = new Bookshelf(125);

            Bookshelf bookShelf50 = new Bookshelf(50);

            Console.WriteLine("The number of books in bookshelf125 is: " + bookShelf125.BookCount);

            Console.WriteLine("The number of books in bookshelf50 is: " + bookShelf50.BookCount);
        }
    }
}
