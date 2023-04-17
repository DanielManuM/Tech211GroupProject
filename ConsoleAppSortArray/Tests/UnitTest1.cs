using ConsoleAppSortArray;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }

    public class MergeSortTEsts
    {
        private int[] _sut = { 299, -8, int.MinValue, 34, -23, int.MaxValue, 2, 3, 13, 23, 50, 99, 12, -34, 2 };

        [Test]
        public void GivenUnsortedArrayOfIntegers_BubbleSort_ReturnsSortedArray()
        {
            int[] expected = { int.MinValue, -34, -23, -8, 2, 2, 3, 12, 13, 23, 34, 50, 99, 299, int.MaxValue };
            Assert.That(BubbleSort(_sut), Is.EquivalentTo(expected));
        }

        [Test]
        public void GivenUnsortedArrayOfIntegers_MergeSort_ReturnsSortedArray()
        {
            int[] expected = { -2147483648, -34, -23, -8, 2, 2, 3, 12, 13, 23, 34, 50, 99, 299, 2147483647 };
            Assert.That(MergeSort(_sut), Is.EqualTo(expected));
        }

        [Test]
        public void GivenTwoLists_Merge_MergesListsTogether()
        {
            List<int> expected = new List<int>() { -2, 1, 2, 2, 5, 5, 9, 10 };
            List<int> left = new List<int>() { 1, 2, 5, 9 };
            List<int> right = new List<int>() { -2, 2, 5, 10 };

            Assert.That(Merge(right, left), Is.EqualTo(expected));
        }
    }
}