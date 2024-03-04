using System;


namespace genricsbase
{
    public class List
    {
        public void Add(int number)
        {
            throw new NotImplementedException();
        }

        public int this[int index]
        {
            get { throw new NotImplementedException();}
        }
    }

    public class BookList
    {
        public void Add(Book book)
        {
            throw new NotImplementedException();
        }

        public Book this[int index]
        {
            get { throw new NotImplementedException();}
        }
    }

    public class Book{}


    public class ObjectList
    {
        public void Add(object book)
        {
            throw new NotImplementedException();
        }

        public object this[int index]
        {
            get { throw new NotImplementedException();}
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book();

            var books  = new BookList();

            books.Add(book);

            var numbers = new List();
            numbers.Add(4);
        }
    }
}
