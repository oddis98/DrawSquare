using System;
using System.Linq;

namespace DrawSquare
{
    class Program
    {
        //Promt method for user input.
        public static int Prompt()
        {

            int number;
            string input;
            
            input = Console.ReadLine();

            try
            {
                number = int.Parse(input);
                return number;
            }
            catch
            {
                Console.WriteLine("That's not a number you dummy!");
                return Prompt();
            }
        }

        //Draw method for actually drawing the Square(s).
        public static void Draw()
        {
            int number = Prompt();
            if (number > 1)
            {
                int vertical = number;

                string topBottom = String.Concat(Enumerable.Repeat("* ", number)); //Creating a sequential string of '*' to be used at top and bottom.
                string space = new string(' ', (vertical * 2) - 3); //White space inside the outer square.

                Console.WriteLine(topBottom);

                if (number < 5) //Checking if the number is big enough to fit another square inside.
                {
                    while (vertical > 2)
                    {
                        Console.WriteLine("*" + space + "*");
                        vertical -= 1;
                    }
                }
                else
                {
                    string innerSpace = new string(' ', (vertical * 2) - 7); //Using magic math to calculate the correct amount of whitespace for inner square.
                    Console.WriteLine(topBottom);

                    while (vertical > 4)
                    {

                        Console.WriteLine("* *" + innerSpace + "* *");
                        vertical -= 1;
                    }
                    Console.WriteLine(topBottom);
                }
                

                Console.WriteLine(topBottom);
            }
            else
            {
                Console.WriteLine("Please enter a larger number");
                Draw();
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            Draw();
        }
    }
}
