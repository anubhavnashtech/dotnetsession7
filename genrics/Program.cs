using System;

namespace genrics
{

    public class GenericList<T>
    {
        public void Add(T value)
        {
            throw new NotImplementedException();
        }

        public T this[int index]
        {
            get { throw new NotImplementedException();}
        }
    }

    public class Book{}


    public class GenericDictionary<Tkey, Tvalue>
    {
        public void Add(Tkey key, Tvalue value)
        {

        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new GenericList<int>();

            numbers.Add(5);

            var books = new GenericList<Book>();

            books.Add(new Book());


            var dictionary = new GenericDictionary<string, Book>();

            dictionary.Add("John", new Book());
        }
    }
}
