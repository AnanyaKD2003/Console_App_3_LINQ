using Console_App_3_LINQ.Data;

namespace Console_App_3_LINQ.Linq
{
    public class SetOperators
    {
        List<int> list1 = new()
        {
            1,2,3,4,5,5,6,6
        };

        List<int> list2 = new()
        {
            4,5,6,7,8,9
        };

        // 1. Distinct()
        // Returns only unique elements by removing duplicates.
        public void DistinctExample()
        {
            var result = list1.Distinct();

            Console.WriteLine("Distinct Numbers:");

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        // 2. Union()
        // Combines two collections and removes duplicate elements.
        public void UnionExample()
        {
            var result = list1.Union(list2);

            Console.WriteLine("Union:");

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        // 3. Intersect()
        // Returns only the elements that are present in both collections.
        public void IntersectExample()
        {
            var result = list1.Intersect(list2);

            Console.WriteLine("Intersect:");

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        // 4. Except()
        // Returns elements from the first collection that are not present in the second.
        public void ExceptExample()
        {
            var result = list1.Except(list2);

            Console.WriteLine("Except:");

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        // 5. Concat()
        // Combines two collections without removing duplicate elements.
        public void ConcatExample()
        {
            var result = list1.Concat(list2);

            Console.WriteLine("Concat:");

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}