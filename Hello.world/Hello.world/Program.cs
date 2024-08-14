using System;





namespace Hello.world
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput = "";
            do
            {
                Console.WriteLine("Hello, World! Would you like to continue (y/n)?");
                userInput = Console.ReadLine();

                if (userInput == "y")
                {
                    continue;
                }


            } while (userInput != "n");
            Console.WriteLine("Bye bye!");
        }

    }
}

        
