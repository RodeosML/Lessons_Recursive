using System;
using System.Linq;

namespace recursive.Task56
{
    //5. Печать только чётных значений из списка
    public class Recursive_FifthTask
    {
        public static void printEvenValuesFromList(List<int> listOfnumbers)
        {
            if (listOfnumbers.Count() == 0)
                return;

            int number = listOfnumbers.First();
            if (number % 2 == 0)
                Console.WriteLine(number);

            List<int> remainingList = listOfnumbers.GetRange(1, listOfnumbers.Count() - 1);

            printEvenValuesFromList(remainingList);
        }
    }

    //6. Печать элементов списка с чётными индексами
    public class Recursive_SixthTask
    {
        public static void printItemEvenIndexFromList(List<string> listOfElements)
        {
            doPrintItemEvenIndexFromList(listOfElements, 0);
        }

        private static void doPrintItemEvenIndexFromList(List<string> listOfElements, int currentIndex)
        {
            if (listOfElements.Count() <= currentIndex)
                return;

            Console.WriteLine(listOfElements.ElementAt(currentIndex));

            doPrintItemEvenIndexFromList(listOfElements, currentIndex + 2);
        }
    }

}

