using System;

namespace Books
{
    class Bookshelf
    {
        public int BookCount {get; set;}

        public Bookshelf(int bookCount)
        {
            this.BookCount = bookCount;
        }
    }
}