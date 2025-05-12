//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Console.WriteLine("Welcome to Git!");

namespace Project
{
    class Functions()
    {
        public static string mainMenu()
        {
            Console.WriteLine("Plaese choose from the options below:");
            Console.WriteLine("a. Input a Series. (Replace the current series)");
            Console.WriteLine("b. Display the series in the order it was entered.");
            Console.WriteLine("c. Display the series in the reversed order it was entered.");
            Console.WriteLine("d. Display the series in sorted order (from low to high).");
            Console.WriteLine("e. Display the Max value of the series.");
            Console.WriteLine("f. Display the Min value of the series.");
            Console.WriteLine("g. Display the Average of the series.");
            Console.WriteLine("h. Display the Number of elements in the series.");
            Console.WriteLine("i. Display the Sum of the series.");
            Console.WriteLine("j. Exit.");
            string userOption = Console.ReadLine();
            return userOption;
        }
        public static string reciveUserNumbers()
        {
            Console.WriteLine("Pleaes enter at least three numbers and put ',' between them without any spaces:");
            string userInput = Console.ReadLine();
            return userInput;
        }
        public static List<int> procecingUserInput(string userInput)
        {
            List<int> listOfNumbers = new List<int>();
            foreach (var charter in userInput.Split(","))
            {
                listOfNumbers.Add(int.Parse(charter));
            }
            return listOfNumbers;
        }
        public static void printSerie(List<int> listOfInts)
        {

            foreach (var item in listOfInts)
            {
                Console.WriteLine(item);
            }
        }
        public static void printReversedSerie(List<int> listOfInts)
        {
            for (int i = listOfInts.Count-1; i > -1; i--)
            {
                Console.WriteLine(listOfInts[i]);
            }
        }
        public static void printInOrder(List<int> listOfInts)
        {
            List<int> tempList = new List<int>();
            List<int> secondTempList = new List<int>();
            foreach (int item in listOfInts)
            {
                tempList.Add(item);
            }
            int counter = tempList.Count;
            while (counter > 0)
            {
                int lowest = tempList[0];
                for (int i = 0; i < tempList.Count; i++)
                {
                    if (tempList[i] < lowest)
                    {
                        lowest = tempList[i];
                    }
                }
                tempList.Remove(lowest);
                secondTempList.Add(lowest);
                counter--;
            }
            foreach (int item in secondTempList)
            {
                Console.WriteLine(item);
            }
        }
        public static void printMax(List<int> listOfInts)
        {
            int max = 0;
            foreach (int item in listOfInts)
            {
                if (max < item)
                {
                    max = item;
                }
            }
            Console.WriteLine(max);
        }
        public static void printMin(List<int> listOfInts)
        {
            int min = listOfInts[0];
            foreach (int item in listOfInts)
            {
                if (min > item)
                {
                    min = item;
                }
            }
            Console.WriteLine(min);
        }
        public static void printAverage(List<int> listOfInts)
        {
            int sum = 0;
            foreach (int item in listOfInts)
            {
                sum += item;
            }
            Console.WriteLine(sum/listOfInts.Count);
        }
        public static void printLen(List<int> listOfInts)
        {
            Console.WriteLine(listOfInts.Count);
        }
        public static void printSum(List<int> listOfInts)
        {
            int sum = 0;
            foreach (int item in listOfInts)
            {
                sum += item;
            }
            Console.WriteLine(sum);
        }
    }
    class Program()
    {
        static void Main()
        {
            bool sign = false;
            bool flag = true;
            List<int> listOfInts = new List<int>();
            while (flag)
            {
                string userChoice = Functions.mainMenu();
                Console.WriteLine();
                char fixedChoice;
                try
                {
                    fixedChoice = char.Parse(userChoice.ToLower());
                }
                catch
                {
                    Console.WriteLine("Wrong Choice");
                    Console.WriteLine();
                    continue;
                }
                if (sign == false && fixedChoice != 'a' && fixedChoice != 'j')
                {
                    Console.WriteLine("Choose 'a' First");
                    Console.WriteLine();
                    continue;
                }
                switch (fixedChoice)
                {
                    case 'a':
                        try
                        {
                            listOfInts = Functions.procecingUserInput(Functions.reciveUserNumbers());
                            Console.WriteLine();
                        }
                        catch
                        {
                            Console.WriteLine("Please enter only numbers");
                            Console.WriteLine();
                            continue;
                        }
                        if (listOfInts.Count < 3)
                        {
                            Console.WriteLine("you have to give at least 3 numbers");
                            Console.WriteLine();
                            continue;
                        }
                        sign = true;
                        break;

                    case 'b':
                        Functions.printSerie(listOfInts);
                        Console.WriteLine();
                        break;

                    case 'c':
                        Functions.printReversedSerie(listOfInts);
                        Console.WriteLine();
                        break;

                    case 'd':
                        Functions.printInOrder(listOfInts);
                        Console.WriteLine();
                        break;

                    case 'e':
                        Functions.printMax(listOfInts);
                        Console.WriteLine();
                        break;

                    case 'f':
                        Functions.printMin(listOfInts);
                        Console.WriteLine();
                        break;

                    case 'g':
                        Functions.printAverage(listOfInts);
                        Console.WriteLine();
                        break;

                    case 'h':
                        Functions.printLen(listOfInts);
                        Console.WriteLine();
                        break;

                    case 'i':
                        Functions.printSum(listOfInts);
                        Console.WriteLine();
                        break;

                    case 'j':
                        flag = false;
                        break;

                    default:
                        Console.WriteLine("You Enetred Wrong Input");
                        Console.WriteLine();
                        break;
                }
            }
        }
    }
}