namespace Homework3.Extensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class IEnumerableExtensions
    {
        public static T SumOfCollection<T>(this IEnumerable<T> array)
        {
            T sum = default(T);
            foreach (var item in array)
            {
                sum = sum + (dynamic)item;
            }

            return sum;
        }

        public static T Product<T>(this IEnumerable<T> array)
        {
            T product = (dynamic)1;
            foreach (var item in array)
            {
                product = product * (dynamic)item;
            }

            return product;
        }

        public static T Minimum<T>(this IEnumerable<T> array)
        {
            return array.Min();
        }

        public static T Maximum<T>(this IEnumerable<T> array)
        {
            return array.Max();
        }

        public static T AverageOfCollection<T>(this IEnumerable<T> array)
        {
            return array.SumOfCollection() / (dynamic)array.Count();
        }
    }
}
