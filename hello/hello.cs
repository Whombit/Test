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

            while(!correct)
            {
                char[] helloWorld = new char[11];
                for(int i = 0; i < helloWorld.Length; i++)
                {
                    int rand = rnd.Next(alphabet.Length);
                    helloWorld[i] = alphabet[rand];

                    string ans = new string(helloWorld);
                    Console.WriteLine(ans);

                    if (ans.Equals("hello world"))
                    {
                        correct = true;
                        break; 
                    }
                }
            } 
        }
    }
}
