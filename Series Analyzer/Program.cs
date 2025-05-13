namespace Project
{
    //Class that contain the functions
    class Functions()
    {

        //Function that shows the menu and recive the choice of the user as string
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

        //Functions that recice some numbers from the user as string
        public static string reciveUserNumbers()
        {
            Console.WriteLine("Pleaes enter at least three numbers and put space between them:");
            string userInput = Console.ReadLine();
            return userInput;
        }

        //Functions that procecing the numbers into list of ints
        public static List<int> procecingUserInput(string userInput)
        {
            List<int> listOfNumbers = new List<int>();
            foreach (var charter in userInput.Split(" "))
            {
                listOfNumbers.Add(int.Parse(charter));
            }
            return listOfNumbers;
        }

        //Functions that print the list
        public static List<int> returnSerie(List<int> listOfInts)
        {
            return listOfInts;
        }

        //Functions that print the list in revers
        public static List<int> returnReversedSerie(List<int> listOfInts)
        {
            List<int> tempList = new List<int>();
            for (int i = listOfInts.Count-1; i > -1; i--)
            {
                tempList.Add(listOfInts[i]);
            }
            return tempList;
        }

        //Functions that sort the list and print it
        public static List<int> returnInOrder(List<int> listOfInts)
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
            return secondTempList;
        }

        //Functions that print the max number in the list
        public static int returnMax(List<int> listOfInts)
        {
            int max = 0;
            foreach (int item in listOfInts)
            {
                if (max < item)
                {
                    max = item;
                }
            }
            return max;
        }

        //Functions that print the min number in the list
        public static int returnMin(List<int> listOfInts)
        {
            int min = listOfInts[0];
            foreach (int item in listOfInts)
            {
                if (min > item)
                {
                    min = item;
                }
            }
            return min;
        }

        //Functions that print the average of the list
        public static int returnAverage(List<int> listOfInts)
        {
            int sum = 0;
            foreach (int item in listOfInts)
            {
                sum += item;
            }
            return sum / listOfInts.Count;
        }

        //Functions that print the len of the list
        public static int returnLen(List<int> listOfInts)
        {
            return listOfInts.Count;
        }

        //Functions that print the sum of the list
        public static int returnSum(List<int> listOfInts)
        {
            int sum = 0;
            foreach (int item in listOfInts)
            {
                sum += item;
            }
            return sum;
        }
        public static void printOnScreen(List<int> listOfIns)
        {
            for (int i = 0; i < listOfIns.Count; i++)
            {
                if (i < listOfIns.Count-1)
                {
                    Console.Write(listOfIns[i]);
                    Console.Write(" ");
                }
                else
                {
                    Console.WriteLine(listOfIns[i]);
                    Console.WriteLine();
                }
            }
        }
    }

    //Class of the Program
    class Program()
    {
        //Functions to run
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
                        Functions.printOnScreen(Functions.returnSerie(listOfInts));
                        break;

                    case 'c':
                        Functions.printOnScreen(Functions.returnReversedSerie(listOfInts));
                        break;

                    case 'd':
                        Functions.printOnScreen(Functions.returnInOrder(listOfInts));
                        break;

                    case 'e':
                        Console.WriteLine(Functions.returnMax(listOfInts));
                        Console.WriteLine();
                        break;

                    case 'f':
                        Console.WriteLine(Functions.returnMin(listOfInts));
                        Console.WriteLine();
                        break;

                    case 'g':
                        Console.WriteLine(Functions.returnAverage(listOfInts));
                        Console.WriteLine();
                        break;

                    case 'h':
                        Console.WriteLine(Functions.returnLen(listOfInts));
                        Console.WriteLine();
                        break;

                    case 'i':
                        Console.WriteLine(Functions.returnSum(listOfInts));
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