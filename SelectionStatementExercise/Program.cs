namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {

            var r = new Random();                               //step 2 var r = new Random(); This is declaring and initializing
            var favNumber = r.Next(0, 100);                     //step 1 declare and initialize a favoriteNumber variable. This is declaring and initializing
            int userInput;                                      //Step 10 is added because to call user input in step 9 you have to call this outside of the scope. 


            do                                                              //Step 8 this do while loop command to continuously ask the user so they can guess more than once. do while loop checks code first then while loop after.
            {

                Console.WriteLine("Input your guess from 1 - 100");             //Step 3 Type Console.WriteLine("Try to guess my favorite number");
                userInput = int.Parse(Console.ReadLine());                      //Step 4 Type var userInput = int.Parse(Console.ReadLine());

                if (userInput < favNumber)
                {
                    Console.WriteLine($"{userInput} Hahaha not even close, that guess is way too low! Sorry");     //Step 5 Create an if-statement that if the guessed number is below the initial value, print out “too low”.

                }
                else if (userInput > favNumber)
                {
                    Console.WriteLine($"{userInput} Your guess is way too high! Sorry bruh");     //Step 6 Create an else-if statement that if the number is higher than the initial value, print out “too high”.
                }
                else
                {
                    Console.WriteLine("You finally got it. But you still a lame!");             //Step 7 Create an else statement that prints out “Nevermind”.
                }


            } while (userInput != favNumber);                                  //Step 9 this will continue to loop if it remains true. While this is true the code will continue to loop.


            //Switch - Case - Excercise 2
            Console.WriteLine("What is your favorite subject");                 //step 1 ask user for the favorite school subject with Console.WriteLine

            string subject = Console.ReadLine();                                //Step 2 Create a variable that will store their answer. 

            switch (subject.ToLower())                                          //Step 3 Create a switch statement and loop in the subject method.
            {
                case "book":                                                    //Step 4 Create all of the cases you want for different subjects.
                    Console.WriteLine("It better be The Alchamist");
                    break;

                case "math":
                case "calculus":
                    Console.WriteLine("I hate Math and will be burning all of my textbooks!");
                    break;

                case "Workout":
                    Console.WriteLine("Abs");
                    break;

                case "science":
                case "physics":
                case "biology":
                    Console.WriteLine("I love science but the earth is flat so...");
                    break;

                case "Hobby":
                    Console.WriteLine("Traveling");
                    break;

                case "pe":
                case "phys ed":
                case "physical education":
                    Console.WriteLine("PE is the best because I get to play basketball!!");
                    break;

                case "history":
                case "pre-historic":
                    Console.WriteLine("History is all a lie");
                    break;

                case "english":
                case "english 2":
                    Console.WriteLine("English is boring accept for when I speak it");
                    break;

                default:
                    Console.WriteLine("I don't know that subject");
                    break;


            }

        }
    }
}
