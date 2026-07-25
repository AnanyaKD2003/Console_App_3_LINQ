using System.Globalization;
using Console_App_3_LINQ.Data;

namespace Console_App_3_LINQ.Linq
{
    public class Partitioning
    {
        List<int> numbers = SampleData.Numbers;

        // 1. Take()
        // Returns the specified number of elements from the beginning of the collection.
        public void TakeExample()
        {
            var first5Numbers = numbers.Take(5);

            Console.WriteLine("First 5 numbers:");

            foreach (var number in first5Numbers)
            {
                Console.WriteLine(number);
            }
        }

        // 2. Skip()
        // Skips the specified number of elements and returns the remaining elements.
        public void SkipExample()
        {
            var allButFirst5Numbers = numbers.Skip(5);

            Console.WriteLine("All but first 5 numbers / After skipping first 5 numbers:");

            foreach (var number in allButFirst5Numbers)
            {
                Console.WriteLine(number);
            }
        }

        // 3. TakeWhile()
        // Returns elements while the specified condition is true.
        public void TakeWhileExample()
        {
            var numbersLessThan50 = numbers.TakeWhile(n => n <= 50);

            Console.WriteLine("Take while Numbers <= 50:");

            foreach (var number in numbersLessThan50)
            {
                Console.WriteLine(number);
            }
        }

        // 4. SkipWhile()
        // Skips elements while the specified condition is true and returns the remaining elements.
        public void SkipWhileExample()
        {
            var numbersGreaterThan50 = numbers.SkipWhile(n => n <= 50);

            Console.WriteLine("Skip while Numbers <= 50:");

            foreach (var number in numbersGreaterThan50)
            {
                Console.WriteLine(number);
            }
        }

        // 5. TakeLast()
        // Returns the specified number of elements from the end of the collection.
        public void TakeLastExample()
        {
            var last3Numbers = numbers.TakeLast(3);

            Console.WriteLine("Last 3 numbers:");

            foreach (var number in last3Numbers)
            {
                Console.WriteLine(number);
            }
        }

        // 6. SkipLast()
        // Skips the specified number of elements from the end of the collection.
        public void SkipLastExample()
        {
            var allButLast3Numbers = numbers.SkipLast(3);

            Console.WriteLine("All but last 3 numbers / After skipping last 3 numbers:");

            foreach (var number in allButLast3Numbers)
            {
                Console.WriteLine(number);
            }
        }

        // 7. Pagination
        // Demonstrates pagination using Skip() and Take().
        public void PaginationExample()
        {
            int pageNumber = 2;
            int pageSize = 3;

            var pagedNumbers = numbers
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize);

            Console.WriteLine($"Page {pageNumber}:");

            foreach (var number in pagedNumbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}