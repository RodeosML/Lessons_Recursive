using System;
using System.Linq;

namespace recursive.Task7
{
    //7. Нахождение второго максимального числа в списке (с учётом, что максимальных может быть несколько, если они равны).
    public class Recursive_SeventhTask
    {
        public static int getSecondMax(int[] values)
        {
            int firstMaxValue = Math.Max(values[0], values[1]);
            int secondMaxValue = Math.Min(values[0], values[1]);

            if (values.Length == 2)
            {
                return secondMaxValue;
            }

            return printSecondMax(values, 2, firstMaxValue, secondMaxValue);
        }

        private static int printSecondMax(int[] values, int index, int firstMaxValue, int secondMaxValue)
        {
            if (index > values.Length - 1)
            {
                return secondMaxValue;
            }

            int currentValue = values[index];

            if (currentValue >= firstMaxValue)
            {
                secondMaxValue = firstMaxValue;
                firstMaxValue = currentValue;
            }

            else if (currentValue > secondMaxValue)
            {
                secondMaxValue = currentValue;
            }

            return printSecondMax(values, index + 1, firstMaxValue, secondMaxValue);
        }

    }

}

