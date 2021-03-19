using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_2
{
    class Program
    {
        static void Main(string[] args)
        {



            bool isRunning = true;
            string lastInput = "";
            while (isRunning)
            {
                Console.WriteLine("Say Something to Bot:");
                string input = Console.ReadLine().ToLower();

                if (lastInput == input)
                {
                    Console.WriteLine("I'm Sorry but you have already said that");
                }
                else
                {
                    lastInput = input;
                    switch (input)
                    {
                        case "hello":
                            Console.WriteLine("Hi good to see you");
                            break;
                        case "bye":
                            Console.WriteLine("Good bye!");
                            isRunning = false;
                            break;
                        case "sup":
                            Console.WriteLine("I am good");
                            break;
                        case "hello there":
                            Console.WriteLine("General Kenobi");
                            break;
                        default:
                            Console.WriteLine("I didn't understand you!");
                            break;
                    }
                }

                if (!isRunning)
                {
                    break;
                }

                Console.WriteLine("Would you like to say something else to the bot? yes/no?");
                string affirmation = Console.ReadLine().ToLower();

                if (!affirmation.Contains("yes"))
                {
                    isRunning = false;
                }
            }




        }
    }
}
