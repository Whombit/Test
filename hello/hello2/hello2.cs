using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();

            char[] alphabet = {'a', 'b', 'c', 'd', 'e', 'f',
                                 'g', 'h', 'i', 'j', 'k', 'l',
                                 'm', 'n', 'o', 'p', 'q', 'r',
                                 's', 't', 'u', 'v', 'w', 'x',
                                 'y', 'z', ' ' };

            bool correct = false;
            char[] helloCorrect = {'h', 'e', 'l', 'l', 'o', ' ', 'w', 'o', 'r', 'l', 'd'};
            char[] helloWorld = new char[11];

            while(!correct)
            {
                for(int i = 0; i <= helloCorrect.length; i++)
                {
                    int rand = rnd.Next(alphabet.Length);
                    if(helloWorld[i] == helloCorrect[i]){
                        Console.WriteLine(helloWorld);
                        string result = string.Join("", helloWorld);
                    }

                }
            } 
        }
    }
}
