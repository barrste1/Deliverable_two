using System;

namespace deliverables2
{
    class Program
    {
        static void Main(string[] args)
        {   string message = "";
            int checksum = 0;
            Console.WriteLine("Hello. Please type in the word you would like encoded.");
            string input = Console.ReadLine();
            input = input.ToUpper();
            foreach (char c in input)
            {
                checksum += c;
                //This converts Unicode character to 1-26 scheme
                int UniCon = c - 64;
                message += UniCon.ToString() + "-";
            }
            //While a final dash is allowed, it kinda bothers me. I'm sure there's a more elegant way to do this but here we go!
            int DashRemove = message.Length - 1;
            Console.WriteLine("Your encoded message is " + message.Substring(0,DashRemove));
            Console.WriteLine("The message Checksum is: "+checksum);
            }

        }
    }