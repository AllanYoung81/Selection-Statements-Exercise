using System.ComponentModel.DataAnnotations;

namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {


            var r = new Random();
            //var favNumber = r.Next(1, 1000);
            var favNumber = 7;
            int userInput;



            do
            {

                Console.WriteLine("Pick a number between 1 and 1000:");
                userInput = int.Parse(Console.ReadLine());

                if (userInput < favNumber)
                {
                    Console.WriteLine($"{userInput} is too low.");
                }

                else if (userInput > favNumber)
                {
                    Console.WriteLine($"{userInput} is too high.");
                }


                else //if (userInput = favNumber)
                {
                    Console.WriteLine("Yup--you guessed it!!!");
                }

            } while (userInput != favNumber);

            SchoolSubject();


        }


        static void SchoolSubject()
        {
            Console.WriteLine("What is your favorite school subject?");
            var subject = Console.ReadLine();

            switch (subject.ToLower())

            {
                case "math":
                    Console.WriteLine("Math is tough, but definitely worth it!");

                    break;

                case "physics":
                    Console.WriteLine("Ouch! Physics is a brutal subject!");

                    break;

                case "history":
                    Console.WriteLine("History is very interesting.");

                    break;

                case "political science":
                    Console.WriteLine("Can anyone even take this class without getting into a fight anymore?");

                    break;

                case "none":
                    Console.WriteLine("None? Better get used to saying 'Would you like fries with that'...");

                    break;
                default:
                    Console.WriteLine($"Intersting--I haven't taken {subject}, at least not yet.");

                    break;

            }





        }


    }


}