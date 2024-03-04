namespace genricsadvance
{

    public class Utilities
    {
        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        // public T Max<T>(T a, T b)
        // {

        //     return a > b ? a : b;
        // }

        public T Max<T>(T a, T b) where T : IComparable
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
    }


// Types of Contraints
// where T  : IComparable
// where T  : Class or any of its derived children
// where T  : value type or struct
// where T  : Ref type
// where T  : new() or default contructor
}