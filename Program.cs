using System;
using System.IO;

//JENNIFER JIMENEZ
//09/24/2020
//Tech Project 3A
//Description: Ask user name and console will respond with by saying hello by name



namespace TechProject3A
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name? Please enter your name...");
            //asking user input, asking for name
            
            try
            {
                SayHi();
                Console.WriteLine("Press any key to exit the program...");
                Console.ReadKey(true);
                //using method SayHi to respond to user input
            }//end of try

            catch
            {
                Console.WriteLine("Please enter a string value for your name and try again...");
                Console.WriteLine("Press any key to exit the program...");
                Console.ReadKey(true);
                //catch in case of errors 
            }//end of catch
        }//end of main

        public static void SayHi()
        {
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name.ToString());
        }
    }//end of class
}//end of namespace
