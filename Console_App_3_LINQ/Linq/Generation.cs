using System.Linq;

namespace Console_App_3_LINQ.Linq
{
    public class Generation
    {
        // 1. Range()
        // Generates a sequence of consecutive numbers.
        public void RangeExample()
        {
            var result = Enumerable.Range(1, 10);

            Console.WriteLine("Numbers from 1 to 10:");

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        // 2. Repeat()
        // Generates a sequence containing the same value multiple times.
        public void RepeatExample()
        {
            var result = Enumerable.Repeat("Hello", 5);

            Console.WriteLine("Repeated Values:");

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        // 3. Empty()
        // Returns an empty sequence of the specified type.
        public void EmptyExample()
        {
            var result = Enumerable.Empty<int>();

            Console.WriteLine($"Count : {result.Count()}");

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}