using System;

namespace Lab3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] name = { "Adam", "Bobby", "Cait", "Donald", "Emily", "Fred", "George", "Hilda", "Ivern", "Jarvin" };
            string[] food = { "Apple", "Banana", "Cabbage", "Donuts", "Eggs", "Fried Chicken", "Goat", "Hotdogs", "Ice cream", "Juice" };
            string[] title = { "Adventurer", "Bowler", "Car salesmen", "Dump truck driver", "Environmentalist", "Fortune teller", "Geologist", "Hang glider", "Inventor", "Juggler" };
            string strStudent;
            string strStudentInfo;
            int student = 0;
            int studentInfo = 0;
            string repeat;
            do
            {
                Console.WriteLine("Which student would you like to know about? 1-10: ");

                bool isValid = false;

                while (!isValid)
                {
                    strStudent = Console.ReadLine();
                    isValid = Int32.TryParse(strStudent, out student);

                    if (!isValid || student < 1 || student > 10)
                    {
                        Console.WriteLine("Please enter a valid input 1-10: ");
                        isValid = false;
                    }

                }

                Console.Write("What info about {0} are you looking for? 1 - Food || 2 - Title: ", name[student - 1]);

                isValid = false;

                while (!isValid)
                {

                    strStudentInfo = Console.ReadLine();
                    isValid = Int32.TryParse(strStudentInfo, out studentInfo);

                    if (!isValid || studentInfo < 1 || studentInfo > 2)
                    {
                        Console.WriteLine("Please enter a valid input 1-2: ");
                        isValid = false;
                    }
                }


                if (studentInfo == 1)
                    Console.WriteLine("{0}'s favorite food is {1}.", name[student - 1], food[student - 1]);
                else
                    Console.WriteLine("{0}'s previous title is {1}.", name[student - 1], title[student - 1]);
                do
                {
                    Console.Write("\nWould you like to learn about another student? y/n: ");
                    repeat = Console.ReadLine().ToLower();

                } while (repeat != "y" && repeat != "n");
            } while (repeat == "y");

            Console.WriteLine("\nThank you! Have a nice day!");
        }
    }
}
