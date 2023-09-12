// Caroline Uthawong-Burr .NET23

namespace MyFirstProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var MyNumber = 16; //This is a variable declaration
            if (MyNumber > 10)
            {
                Console.WriteLine("Talet är stort!");
            }
            else
            {
                Console.WriteLine("Oj! Lågt tal!");
            }
            Console.WriteLine("Vad heter du?");
            var Name = Console.ReadLine(); // Store user input
            Console.WriteLine("Hej " + Name);

            var MyCounting = 0;
            while (MyNumber >= MyCounting) //The while loop finishes one round too early without the equal sign.
            {
                Console.WriteLine(MyCounting);
                MyCounting++;
            }
        }
    }
}