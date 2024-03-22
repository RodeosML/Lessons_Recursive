using recursive.Task56;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        var numbers = new List<int>() { 2, 1, 1, 1, 1, 3 };
        recursive.Task56.Recursive_FifthTask.printEvenValuesFromList(numbers);

        var numbers2 = new List<string>() { "привет", "привет2", "привет3", "привет4", "привет4", };
        recursive.Task56.Recursive_SixthTask.printItemEvenIndexFromList(numbers2);
    }
}