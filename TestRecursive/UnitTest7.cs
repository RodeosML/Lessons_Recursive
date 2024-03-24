using recursive.Task7;

namespace TestRecursive3;

[TestClass]
public class UnitTestRecursive
{
    [TestMethod]
    public void TestMethod_GetSecondMax()
    {
        int[] listNums1 = new int[] { 1, 2, 3, 5 };

        int[] listNums2 = new int[] { 2, 5, 4, 3, 5 };

        int[] listNums3 = new int[] { 2, 3, 5, 4 };

        int[] listNums4 = new int[] { 1, 3, 3, 4};

        var firstGetValue = Recursive_SeventhTask.getSecondMax(listNums1);

        var secondGetValue = Recursive_SeventhTask.getSecondMax(listNums2);

        var thirdGetValue = Recursive_SeventhTask.getSecondMax(listNums3);

        var forthGetValue = Recursive_SeventhTask.getSecondMax(listNums4);

        Assert.AreEqual(3, firstGetValue);

        Assert.AreEqual(5, secondGetValue);

        Assert.AreEqual(4, thirdGetValue);

        Assert.AreEqual(3, forthGetValue);
    }
}
