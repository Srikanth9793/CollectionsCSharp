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
    }
}
