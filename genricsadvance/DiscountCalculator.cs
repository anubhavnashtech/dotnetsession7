namespace genricsadvance
{
    public class Product
    {

        public string Title { get; set; }

        public float Price { get; set; }

    }

    public class Books : Product
    {

        public int ISBN { get; set; }

    }


    public class DiscountCalculator<TBooks> where TBooks : Books
    {

        public float CalculateDiscount(TBooks product)
        {
            return product.Price;
        }

    }


    // Value tye constraint

    public class Nullable<T> where T : struct
    {
        private object _value;

        public Nullable()
        {

        }

        public Nullable(T value)
        {
            _value = value;

        }

        public bool HasValue
        {
            get {return _value != null; }
        }

        public T GetValueOrDefault()
        {
            if(HasValue)
            return (T)_value;

            return default(T);
        }

    }


}