using System;
using System.Runtime.ConstrainedExecution;

namespace genricsadvance
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
            var number = new Nullable<int>();
            System.Console.WriteLine( "Has Value ? " + number.HasValue  );
            System.Console.WriteLine("Value : " + number.GetValueOrDefault());
        }
    }
}
