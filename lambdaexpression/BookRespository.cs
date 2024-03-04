namespace lambdaexpression
{
    public class Book
    {
        public string Title { get; set; }

        public float Price { get; set; }

    }

    public class BookRespository
    {

        public List<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book() { Title = "Title 1" , Price = 5},
                new Book() { Title = "Title 2" , Price = 7},
                new Book() { Title = "Title 3" , Price = 17},
            };
        }


    }


}