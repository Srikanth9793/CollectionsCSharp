using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class Genericss
    {
        public void Display<T>(T value)
        {
            Console.WriteLine($"Type: {typeof(T)}, Value: {value}");
        }
        
    }

    public class GenericClass<T>
    {
        public T value;
    }
}
