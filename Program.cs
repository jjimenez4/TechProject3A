using System;
using System.IO;

namespace TechProject3A
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name? Please enter your name...");
            
            try
            {
                SayHi();
                Console.WriteLine("Press any key to exit the program...");
                Console.ReadKey(true);
            }//end of try

            catch
            {
                Console.WriteLine("Please enter a string value for your name and try again...");
                Console.WriteLine("Press any key to exit the program...");
                Console.ReadKey(true);
            }//end of catch
        }//end of main

        public static void SayHi()
        {
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name.ToString());
        }
    }//end of class
}//end of namespace
