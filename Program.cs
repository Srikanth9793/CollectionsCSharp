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

            Console.ReadKey();
        }
    }
}
