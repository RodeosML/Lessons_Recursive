namespace TasksRecursive
{
    //1. Возведение числа N в степень M
    public class Recursive_FirstTask
    {
        public static double calculateNumberRaisedToPower(int number, int degree)
        {
            if (degree == 0)
                return 1;

            if (degree < 0)
                return 1 / increaseNumberToPower(number, -degree);

            return increaseNumberToPower(number, degree);

        }

        private static double increaseNumberToPower(int number, int degree)
        {
            if (degree == 1)
                return number;
            else
                return number * increaseNumberToPower(number, degree - 1);
        }

    }

    //2. Вычисление суммы цифр числа
    public class Recursive_SecondTask
    {
        public static int сalculateSumDigitsNumber(int number)
        {
            if (number < 10)
                return number;
            else
                return number % 10 + сalculateSumDigitsNumber(number / 10);
        }
    }
}