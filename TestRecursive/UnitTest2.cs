using recursive.Task34;

namespace TestRecursive2;

[TestClass]
public class UnitTestRecursive
{
    [TestMethod]
    public void TestMethod_ComputeLengthList()
    {
        List<string> list = new List<string>() { "1", "2", "3" };

        var firstCalculatedValue = recursive.Task34.Recursive_ThirdTask.computeLengthList(list);

        List<string> list2 = new List<string>() { };

        var secondCalculatedValue = recursive.Task34.Recursive_ThirdTask.computeLengthList(list2);


        Assert.AreEqual(3, firstCalculatedValue);
        Assert.AreEqual(0, secondCalculatedValue);
    }

    [TestMethod]
    public void TestMethod_isPolindrom()
    {
        var row = "шалаш";

        var firstCalculatedValue = recursive.Task34.Recursive_FourthTask.isPolindrom(row);

        var row2 = "да";

        var secondCalculatedValue = recursive.Task34.Recursive_FourthTask.isPolindrom(row2);


        Assert.AreEqual(true, firstCalculatedValue);
        Assert.AreEqual(false, secondCalculatedValue);
    }
}
