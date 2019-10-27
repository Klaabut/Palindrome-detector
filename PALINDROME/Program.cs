using System;

namespace PALINDROME
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            string reversed;
            char[] Palin = name.ToCharArray();

            Array.Reverse(Palin);
            reversed = new string(Palin);

            if (name == reversed)
            {
                Console.WriteLine("Your name is a palindrome. ");
            }
            else
            {
                Console.WriteLine("Your name is not a palindrome.");
            }

            
            



            Console.ReadLine();
        }

      



        
    }

}
