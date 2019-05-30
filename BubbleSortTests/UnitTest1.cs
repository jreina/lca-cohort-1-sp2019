using Microsoft.VisualStudio.TestTools.UnitTesting;
using BubbleSort;

namespace BubbleSortTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void should_sort_in_descending_order()
        {
            var input = new int[] { 1, 2, 3 };
            var actual = Class1.BubbleSort(input);
            var expected = new int[] { 3, 2, 1 };

            CollectionAssert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void should_sort_in_descending_order_2()
        {
            var input = new int[] { -10, 20, 5, 66, -63 };
            var actual = Class1.BubbleSort(input);
            var expected = new int[] { 66, 20, 5, -10, -63 };

            CollectionAssert.AreEqual(actual, expected);
        }
    }
}
