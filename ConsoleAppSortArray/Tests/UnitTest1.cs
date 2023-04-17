using ConsoleAppSortArray;

namespace Tests
{
    public class Tests
    {
        [TestFixture]
        public class BubbleSort
        {
            [Test]
            public void GivenAnEmptyArrayReturnsEmptyArray()
            {
                var testArray = new int[] { };
                var output = BubbleSortClass.BubbleSort(testArray);
                Assert.That(output, Is.EqualTo(testArray));
            }

            [Test]

            public void GivenAnArrayWithNElements_ReturnsArrayWithSameLength()
            {
                var testArray = new int[] { 1, 2, 3 };
                var output = BubbleSortClass.BubbleSort(testArray).Length;
                Assert.That(output, Is.EqualTo(3));
            }

            [Test]

            public void GivenAnArrayWithNElements_ReturnsArrayWithSameArraySortedLowToHigh()
            {
                var testArray = new int[] { 5, 1, -3, 3, 6 };
                var output = BubbleSortClass.BubbleSort(testArray);
                Assert.That(output, Is.EqualTo(new int[] { -3, 1, 3, 5, 6 }));
            }
        }

        [TestFixture]
        public class MergeSortTests
        {
            private MergeSort mergeSort;
            private int[] _sut = { 299, -8, int.MinValue, 34, -23, int.MaxValue, 2, 3, 13, 23, 50, 99, 12, -34, 2 };

            [SetUp]
            public void SetUp()
            {
                mergeSort = new MergeSort();
            }

            [Test]
            public void GivenEmptyArray_MergeSort_ReturnsEmptyArray()
            {
                Assert.That(mergeSort.Sort(new int[0]), Is.EquivalentTo(new int[] {}));
            }

            [Test]
            public void GivenNullAsAnInput_MergeSort_ThrowsException()
            {
                Assert.That(() => mergeSort.Sort(null), Throws.InstanceOf<ArgumentNullException>()
                    .With.Message.Contain("Input cannot be null. (Parameter 'unsortedArray')"));
            }

            [Test]
            public void GivenUnsortedArrayOfIntegers_MergeSort_ReturnsSortedArray()
            {
                int[] expected = { int.MinValue, -34, -23, -8, 2, 2, 3, 12, 13, 23, 34, 50, 99, 299, int.MaxValue };
                Assert.That(mergeSort.Sort(_sut), Is.EquivalentTo(expected));
            }

            [Test]
            public void GivenTwoLists_Merge_MergesListsTogether()
            {
                List<int> expected = new List<int>() { -2, 1, 2, 2, 5, 5, 9, 10 };
                List<int> left = new List<int>() { 1, 2, 5, 9 };
                List<int> right = new List<int>() { -2, 2, 5, 10 };

                Assert.That(mergeSort.Merge(left, right), Is.EqualTo(expected));
            }
        }
    }
}