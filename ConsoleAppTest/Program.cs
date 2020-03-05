using System;

namespace ConsoleAppTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string name = "Angelo J.";
            string lastname = "Chacin";

            Console.WriteLine("TRABAJANDO CON CADENAS");
            Console.WriteLine("My name: {0}", name);
            Console.WriteLine(String.Format("Mi nombre es {0}", name));
            Console.WriteLine($"My name full is: { name } { lastname }.");
        }
    }
}
