namespace SimpleQuizApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string question1 = "what's the coolest shirt?";
            string answer1 = "Hawian Shirt";

            string question2 = "when do you sow grass, which season?";
            string answer2 = "Fall";

            string question3 = "whats the coolest drink?";
            string answer3 = "Water";

            int score = 0;

            //Question #1:
            Console.WriteLine("First Question:");
            Console.WriteLine("\n"+question1);

            string userAnswer1 = Console.ReadLine();

            if(userAnswer1.Trim().ToLower() == answer1.ToLower())
            {
                Console.WriteLine("Correct!");
                score++;
            }
            else
            {
                Console.WriteLine($"Incorrect, the right answer is: {answer1}");
            }

            //Question #2:
            Console.WriteLine("Next Question:");
            Console.WriteLine("\n" + question2);

            string userAnswer2 = Console.ReadLine();

            if (userAnswer2.Trim().ToLower() == answer2.ToLower())
            {
                Console.WriteLine("Correct!");
                score++;
            }
            else
            {
                Console.WriteLine($"Incorrect, the right answer is: {answer2}");
            }

            //Question #3:
            Console.WriteLine("Next Question:");
            Console.WriteLine("\n" + question3);

            string userAnswer3 = Console.ReadLine();

            if (userAnswer3.Trim().ToLower() == answer3.ToLower())
            {
                Console.WriteLine("Correct!");
                score++;
            }
            else
            {
                Console.WriteLine($"Incorrect, the right answer is: {answer3}");
            }

            if(score == 3)
            {
                Console.WriteLine("You have answered all the questions right. Congrats!");
            }
            else if(score > 0)
            {
                Console.WriteLine($"\n\tYou have answered {score} questions right.");
            }
            else
            {
                Console.WriteLine($"\n\tYou can try again, You got this");
            }
            Console.WriteLine($"\n\tYour score is: {score}/3");

            Console.ReadLine();
        }
    }
}
