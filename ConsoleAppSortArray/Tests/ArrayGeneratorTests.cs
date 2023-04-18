using ConsoleAppSortArray;

namespace Tests;

public class ArrayTest
{
    [Test]
    public void GivenNumberReturnArrayOfThatLength()
    {
        Assert.That(ArrayGenerator.RandomArrayGenerator(10), Has.Length.EqualTo(10)); 
    }

}
