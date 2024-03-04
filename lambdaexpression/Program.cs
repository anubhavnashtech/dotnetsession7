namespace lambdaexpression
{
    class Program
    {
        static void Main(string[] args)
        {
        //    System.Console.WriteLine(Square(5));


        //    // Syntax for lambda expres:  args => expression 
        //    // number => number*number 

        //  Func<int, int> square = number => number*number;
           
        //  System.Console.WriteLine(square(2));

        //LambdaDemo();

       LambdaPracticalExample();

        }

        static int Square(int number)
        {
            return number*number;
        }

        public static void LambdaDemo()
        {
            // () => .....
            // x => .....
            //(x, y, z) => .....

            const int factor = 5;

            Func<int, int> multiplier = number => number*factor;

            var result = multiplier(10);

            System.Console.WriteLine(result);
        }


        public static void LambdaPracticalExample()
        {


            // Without Lambda expression

            var books  = new BookRespository().GetBooks();

            var cheapBooks  = books.FindAll(IsCheaperThan10);

            foreach(var book in cheapBooks)
            {
                System.Console.WriteLine(book.Title);
            }


            // With Lambda expression

           var cheapBookss  = books.FindAll(book => book.Price < 10);

            foreach(var book in cheapBooks)
            {
                System.Console.WriteLine(book.Title);
            }


        }

        static bool IsCheaperThan10(Book book)
        {
            return book.Price < 10 ? true : false;
        }
    }
}
