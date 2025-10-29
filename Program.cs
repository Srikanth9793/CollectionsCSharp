namespace ExceptionHandling
{

    public class MyCustomException : Exception
    {
        public MyCustomException(): base("Invalid Input") { }

        public MyCustomException(string message): base(message) { }
    }
    internal class Program
    {

        public static void Validate(int age)
        {
            if (age < 18)
            {
                throw new MyCustomException("Sorry, You are Age must be graeter than 18 to buy Alchol");
            }
        }
        static void Main(string[] args)
        {
            //try
            //{
            //    Validate(17);
            //}
            //catch (MyCustomException ex)
            //{
            //    Console.WriteLine($"Exception should be: {ex.Message}");
            //}

            //Console.WriteLine("Program Continous");

            //int value = int.MaxValue;
            ////Console.WriteLine(value + 2);

            //try
            //{
            //    checked
            //    {
            //        int result = value + 1;
            //        Console.WriteLine($"The result is: {result}");
            //    }


            //}
            //catch(OverflowException ex)
            //{
            //    Console.WriteLine("OverFlow Detected: " + ex.Message);
            //}

            //int y = int.MaxValue;
            //unchecked
            //{
            //    int result = y + 1;
            //    Console.WriteLine($"The result is: {result}");
            //}
            //Console.ReadKey();
            Collections ob = new Collections();
            
            ob.ListCollection();
            ob.HashSetCollection();

            ob.SortedSetCollection();
            try
            {
                ob.DictionaryCollection();
            }
            catch(MyCustomException ex)
            {
                Console.WriteLine("Custom Exception: " + ex.Message);
            }

            ob.SortedListCollection();

            // Genrics
            Genericss genericss = new Genericss();
            genericss.Display<string>("srikanth");
            genericss.Display<float>(10.56f);
            genericss.Display<double>(3.14);
            genericss.Display<bool>(true);


            // Generic Class
            GenericClass<int> genericClassInt = new GenericClass<int>();
            genericClassInt.value = 100;
            Console.WriteLine($"Generic class of type Integer is: {genericClassInt.value}");

            GenericClass<string> genericClassString = new GenericClass<string>();
            genericClassString.value = "srikanth";
            Console.WriteLine($"Generic class of type string  is: {genericClassString.value}");




            Console.ReadKey();
        }
    }
}
