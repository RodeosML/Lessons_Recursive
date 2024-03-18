using TasksRecursive;

namespace TestRecursive;

[TestClass]
public class UnitTestRecursive
{
    [TestMethod]
    public void TestMethod_CalculateExponentiationNumber()
    {
        int firstNumber = 5;
        int firstDegree = 3;

        var firstCalculatedValue = TasksRecursive.Recursive_FirstTask.calculateNumberRaisedToPower(firstNumber, firstDegree);

        int secondNumber = 5;
        int secondDegree = 1;

        var secondCalculatedValue = TasksRecursive.Recursive_FirstTask.calculateNumberRaisedToPower(secondNumber, secondDegree);

        int thirdNumber = 5;
        int thirdDegree = -1;

        var thirdCalculatedValue = TasksRecursive.Recursive_FirstTask.calculateNumberRaisedToPower(thirdNumber, thirdDegree);

        int fourthNumber = 5;
        int fourthDegree = 0;

        var fourthCalculatedValue = TasksRecursive.Recursive_FirstTask.calculateNumberRaisedToPower(fourthNumber, fourthDegree);

        Assert.AreEqual(125, firstCalculatedValue);
        Assert.AreEqual(5, secondCalculatedValue);
        Assert.AreEqual(0.2, thirdCalculatedValue);
        Assert.AreEqual(1, fourthCalculatedValue);
    }

    [TestMethod]
    public void TestMethod_CalculateSumDigitsNumber()
    {
        int firstNumber = 5;

        var firstCalculatedValue = TasksRecursive.Recursive_SecondTask.сalculateSumDigitsNumber(firstNumber);

        int secondNumber = 25405;

        var secondCalculatedValue = TasksRecursive.Recursive_SecondTask.сalculateSumDigitsNumber(secondNumber);

        Assert.AreEqual(5, firstCalculatedValue);
        Assert.AreEqual(16, secondCalculatedValue);
    }
}
