//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Console.WriteLine("Welcome to Git!");

namespace Project
{
    class Functions()
    {
        public static char mainMenu()
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
            char userOption;
            try
            {
                userOption = char.Parse(Console.ReadLine());

            }
            catch (Exception e)
            {
                throw e.InnerException;
            }
            return userOption;
        }
        public static string reciveUserNumbers()
        {
            Console.WriteLine("Pleaes enter numbers and put ',' between them without any spaces:");
            string userInput = Console.ReadLine();
            return userInput;
        }
        public static List<Int32> procecingUserInput(string userInput)
        {
            string stringNumbers = "123456789";
            List<Int32> listOfNumbers = new List<int>();
            foreach (var charter in userInput.Split(","))
            {
                listOfNumbers.Add(Int32.Parse(charter));
            }
            return listOfNumbers;
        }
        public static void printSerie(List<Int32> listOfInts)
        {
            foreach (var item in listOfInts)
            {
                Console.WriteLine(item);
            }
        }
        public static void printReversedSerie(List<Int32> listOfInts)
        {
            List<Int32> tempList = new List<int>();
            foreach (Int32 item in listOfInts)
            {
                tempList.Add(item);
            }
            foreach (var item in tempList)
            {
                Console.WriteLine(item);
            }
        }
        public static void printInOrder(List<Int32> listOfInts)
        {
            List<Int32> tempList = new List<int>();
            int lowest = 0;
            while (listOfInts.Count > 0)
            {
                for (int i = 0; i < listOfInts.Count; i++)
                {
                    if (listOfInts[i] < lowest)
                    {
                        lowest = listOfInts[i];
                    }
                }
                listOfInts.Remove(lowest);
                tempList.Add(lowest);
            }
            foreach (Int32 item in tempList)
            {
                Console.WriteLine(item);
            }
        }
        public static void printMax(List<Int32> listOfInts)
        {
            Int32 max = 0;
            foreach (Int32 item in listOfInts)
            {
                if (max < item)
                {
                    max = item;
                }
            }
            Console.WriteLine(max);
        }
        public static void printMin(List<Int32> listOfInts)
        {
            Int32 min = listOfInts[0];
            foreach (Int32 item in listOfInts)
            {
                if (min > item)
                {
                    min = item;
                }
            }
            Console.WriteLine(min);
        }
        public static void printAverage(List<Int32> listOfInts)
        {
            int sum = 0;
            foreach (Int32 item in listOfInts)
            {
                sum += item;
            }
            Console.WriteLine(sum/listOfInts.Count);
        }
        public static void printLen(List<Int32> listOfInts)
        {
            Console.WriteLine(listOfInts.Count);
        }
        public static void printSum(List<Int32> listOfInts)
        {
            int sum = 0;
            foreach (Int32 item in listOfInts)
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
            while (true)
            {
                List<Int32> listOfInts = new List<int>();
                char userChoice = Functions.mainMenu();
                switch (char.Parse(userChoice.ToString().ToLower()))
                {
                    case 'a':
                         listOfInts = Functions.procecingUserInput(Functions.reciveUserNumbers());
                        break;

                    case 'b':
                        Functions.printSerie(listOfInts);
                        break;

                    case 'c':
                        Functions.printReversedSerie(listOfInts);
                        break;

                    case 'd':
                        Functions.printInOrder(listOfInts);
                        break;

                    case 'e':
                        Functions.printMax(listOfInts);
                        break;

                    case 'f':
                        Functions.printMin(listOfInts);
                        break;

                    case 'g':
                        Functions.printAverage(listOfInts);
                        break;

                    case 'h':
                        Functions.printLen(listOfInts);
                        break;

                    case 'i':
                        Functions.printSum(listOfInts);
                        break;

                    case 'j':
                        return;

                    default:
                        Console.WriteLine("You Enetred Wrong Input");
                        break;
                }
            }
        }
    }
}