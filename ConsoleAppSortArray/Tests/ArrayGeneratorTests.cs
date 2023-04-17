using ConsoleAppSortArray;

namespace Tests;

public class ArrayTest
{
    [Test]
    public void GivenNumberReturnArrayOfThatLength()
    {
        var arrayGen = new ArrayGenerator();
        Assert.That(arrayGen.RandomArrayGenerator(10), Has.Length.EqualTo(10)); 
    }

}
