using System.Globalization;
using Console_App_3_LINQ.Data;

namespace Console_App_3_LINQ.Linq
{
    public class Partitioning
    {
        List<int> numbers = SampleData.Numbers;

        // Take()
        public void TakeExample()
        {
            var first5Numbers = numbers.Take(5);
            Console.WriteLine("First 5 numbers:");
            foreach (var number in first5Numbers)
            {
                Console.WriteLine(number);
            }
        }

        // Skip()
        public void SkipExample()
        {
            var allButFirst5Numbers = numbers.Skip(5);
            Console.WriteLine("All but first 5 numbers/ After skipping first 5 numbers:");
            foreach (var number in allButFirst5Numbers)
            {
                Console.WriteLine(number);
            }
        }

        // TakeWhile()
        public void TakeWhileExample()
        {
            var numbersLessThan50 = numbers.TakeWhile(n => n <= 50);
            Console.WriteLine("Take while Numbers <= 50:");
            foreach (var number in numbersLessThan50)
            {
                Console.WriteLine(number);
            }
        }

        // SkipWhile()
        public void SkipWhileExample()
        {
            var numbersGreaterThan50 = numbers.SkipWhile(n => n <= 50);
            Console.WriteLine("Skip while Numbers <= 50:");
            foreach (var number in numbersGreaterThan50)
            {
                Console.WriteLine(number);
            }
        }

        // TakeLast()
        public void TakeLastExample()
        {
            var last3Numbers = numbers.TakeLast(3);
            Console.WriteLine("Last 3 numbers:");
            foreach (var number in last3Numbers)
            {
                Console.WriteLine(number);
            }
        }

        // SkipLast()
        public void SkipLastExample()
        {
            var allButLast3Numbers = numbers.SkipLast(3);
            Console.WriteLine("All but last 3 numbers/ After skipping last 3 numbers:");
            foreach (var number in allButLast3Numbers)
            {
                Console.WriteLine(number);
            }
        }

        // Pagination Example
        public void PaginationExample()
        {
            int pageNumber = 2; // Example: Get the second page
            int pageSize = 3;   // Example: Each page contains 3 items

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