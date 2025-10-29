using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class Collections
    {
        public void ListCollection()
        {
            // List
            List<int> numbers = new List<int>() { 10, 20, 30, 40};
            Console.WriteLine("Initial List: " + string.Join(", ", numbers));

            // Add
            numbers.Add(50);
            numbers.AddRange(new int[] { 60, 70 });
            Console.WriteLine("\nAfter Add & AddRange: " + string.Join(", ", numbers));

            // Insert
            numbers.Insert(1, 15);
            numbers.InsertRange(4, new int[] { 32, 36 });
            Console.WriteLine("\nAfter Insert & InsertRange: " + string.Join(", ", numbers));

            // Remove
            numbers.Remove(15);
            numbers.RemoveAt(0);
            numbers.RemoveRange(2, 2); // starting from idx 2 remove 2 elements
            Console.WriteLine("\nAfter Remove, RemoveAt, RemoveRange: " + string.Join(", ", numbers));

            // Searching
            Console.WriteLine("\nContains 20? " + numbers.Contains(20));
            Console.WriteLine("IndexOf 40: " + numbers.IndexOf(40));
            Console.WriteLine("Find first > 50: " + numbers.Find(x => x > 50));
            Console.WriteLine("FindAll even numbers: " + string.Join(", ", numbers.FindAll(x => x % 2 == 0)));
            Console.WriteLine("Exists < 10? " + numbers.Exists(x => x < 10));

            // Iteration
            Console.WriteLine("\nUsing foreach loop:");
            foreach (int n in numbers)
                Console.Write(n + " ");

            Console.WriteLine("\nUsing ForEach method:");
            numbers.ForEach(n => Console.Write(n + " "));

            // sort and Reverse
            numbers.Sort();
            Console.WriteLine("\n\nAfter Sort: " + string.Join(", ", numbers));

            numbers.Reverse();
            Console.WriteLine("After Reverse: " + string.Join(", ", numbers));

            // Copy
            int[] arr = numbers.ToArray();
            Console.WriteLine("\nToArray: " + string.Join(", ", arr));

            List<int> subList = numbers.GetRange(1, 3);
            Console.WriteLine("GetRange(1,3): " + string.Join(", ", subList));

            // Properties
            Console.WriteLine("\nCount: " + numbers.Count);
            Console.WriteLine("Capacity: " + numbers.Capacity);
            Console.WriteLine("Element at index 2: " + numbers[2]);

            numbers.Clear();
            Console.WriteLine("\nAfter Clear: Count = " + numbers.Count);

            Console.WriteLine("\n✅ All List operations executed successfully!");

        }

        public void HashSetCollection()
        {
            HashSet<int> numbers = new HashSet<int>();

            numbers.Add(10);
            numbers.Add(11);
            numbers.Add(12);
            numbers.Add(13);
            numbers.Add(13);

            Console.WriteLine("\n\nValues are: " + string.Join(", " , numbers));

            // Remove
            numbers.Remove(10);

            // Check existence
            Console.WriteLine("Contains 30? " + numbers.Contains(30));

            // Union and Intersection (Set Operations)
            HashSet<int> other = new HashSet<int> { 30, 40, 50 };

            numbers.UnionWith(other);          // Combine both sets
            Console.WriteLine("After Union: " + string.Join(", ", numbers));

            numbers.IntersectWith(other);      // Keep only common elements
            Console.WriteLine("After Intersection: " + string.Join(", ", numbers));

            // Clear all
            numbers.Clear();
            Console.WriteLine("Count after Clear: " + numbers.Count);

        }

        public void SortedSetCollection()
        {
            SortedSet<int> numbers = new SortedSet<int>();
            numbers.Add(10);
            numbers.Add(11);
                
            numbers.Add(12);
            numbers.Add(9);
            numbers.Add(13);
            numbers.Add(13);

            Console.WriteLine("\n\nSorted Set values are: " + string.Join(", ", numbers));

            Console.WriteLine("Conatins ?" + numbers.Contains(9));
        }

        public void DictionaryCollection()
        {
            try
            {
                Dictionary<int, string> keyValuePairs = new Dictionary<int, string>();

                keyValuePairs.Add(1, "srikanth");
                keyValuePairs.Add(2, "John");
                keyValuePairs.Add(3, "Johny");
                keyValuePairs.Add(4, "Tazu");
                keyValuePairs.Add(5, "Tazu");

               

                foreach (var details in keyValuePairs)
                {
                    Console.WriteLine($"Key is {details.Key} : {details.Value}");
                }

            }
            catch (Exception ex)
            {
                throw new MyCustomException("Dictionary contains key value pairs key must be unique" + ex.Message);
            }
           

        }

        public void SortedListCollection()
        {
            SortedList<string, int> marks = new SortedList<string, int>();

            marks.Add("C++", 90);
            marks.Add("Python", 85);

            marks.Remove("C++");

            foreach (var details in marks)
            {
                Console.WriteLine($"\n\nKey is {details.Key} : {details.Value}");
            }
        }
    }
}
