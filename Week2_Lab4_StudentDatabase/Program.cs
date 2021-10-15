using System;

namespace Week2_Lab4_StudentDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] students = { "Yosha", "Marjorie", "James", "Cordero", "Rick", "Calyn", "Anurag", "Huy", "Tommy", "Ramone" };
            string[] favFoods = { "biryani, a type of rice mixed with meat", "lasagna", "katsu, a Japanese dish of fried chicken", "BBQ of any type", "the classic hamburger", "macaroni and cheese", "tacos", "korean BBQ", "curry", "chicken soup" };
            string[] hometowns = { "Rochester Hills, MI", "Detroit, MI", "Yap, an island in the Federated States of Micronesia", "Berkley, MI", "Gilbert, AZ", "Portage, MI", "Rochester Hills, MI", "Lansing, MI", "Raleigh, NC", "Fort Lauderdale, FL" };

            int num = students.Length;
            bool goOn = true;

            Console.WriteLine("Welcome to Meet Your Classmates!");
            Console.WriteLine("Here are your classmates:");

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine(i + "." + " " + students[i]);
            }
            while (goOn == true)
            {
                Console.WriteLine("Which student would you like to learn more about?");
                Console.WriteLine("Please enter either a student number: ");

                string userInput = Console.ReadLine();
                int userNumber = int.Parse(userInput);


                while (userNumber <= students.Length)
                {
                    Console.WriteLine($"What would you like to know about {students[userNumber]}?");
                    Console.WriteLine("For hometown, enter: 1");
                    Console.WriteLine("For favorite food, enter: 2");
                    string userNumber2 = Console.ReadLine();

                    if (userNumber2 == "1")
                    {
                        //Console.WriteLine($"{students[userNumber]}'s hometown is {hometowns[userNumber]}.");
                        Console.WriteLine(students[1, 2, 3]);

                    }
                    else if (userNumber2 == "2")
                    {
                        Console.WriteLine($"{students[userNumber]}'s favorite food is {favFoods[userNumber]}.");
                    }

                    Console.WriteLine("Would you like to learn about another student? y/n");
                    string userAnswer = Console.ReadLine();

                    if (userAnswer == "y")
                    {
                        goOn = true;
                    }
                    else if (userAnswer == "n")
                    {
                        Console.WriteLine($"No problem. Enjoy the rest of your day!");
                        goOn = false;
                    }
                    else
                    {
                        Console.WriteLine($"Sorry, '{userAnswer}' is not a valid response. \nPlease enter 'y' to continue or 'n' to exit.");
                        //Console.WriteLine("Please enter 'y' to continue or 'n' to exit.");
                        goOn = false;

                    }
                }
            }

        }
    }
}

