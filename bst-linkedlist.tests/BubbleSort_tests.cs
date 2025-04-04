using System;
using bst_linkedlist.library;
using bst_linkedlist.library.SinglyLinkedList;

namespace bst_linkedlist.tests
{
    [TestClass]
    public class BubbleSort_tests
    {
        [TestMethod]
        public void BubbleSort_SortsArrayInAscendingOrder()
        {
            // Arrange
            ListInt input = new ListInt();
            input.Add(5);
            input.Add(2);
            input.Add(9);
            input.Add(1);
            input.Add(8);
            input.Add(6);
            ListInt expected = new ListInt();
            expected.Add(5);
            expected.Add(2);
            expected.Add(9);
            expected.Add(1);
            expected.Add(8);
            expected.Add(6);

            // Act
            ListInt result = BubbleSort.Sort(input);

            // Assert
            Assert.AreEqual(expected.ToString(), result.ToString());
        }

        [TestMethod]
        public void BubbleSort_HandlesEmptyArray()
        {
            // Arrange
            ListInt input = new ListInt();
            ListInt expected = new ListInt();

            // Act
            ListInt result = BubbleSort.Sort(input);

            // Assert
            Assert.AreEqual(expected.ToString(), result.ToString());
        }

        [TestMethod]
        public void BubbleSort_HandlesSingleElementArray()
        {
            // Arrange
            ListInt input = new ListInt();
            input.Add(42);
            ListInt expected = new ListInt();
            input.Add(42);

            // Act
            ListInt result = BubbleSort.Sort(input);

            // Assert
            Assert.AreEqual(expected.ToString(), result.ToString());
        }

        [TestMethod]
        public void BubbleSort_HandlesAlreadySortedArray()
        {
            // Arrange
            ListInt input = new ListInt();
            input.Add(1);
            input.Add(2);
            input.Add(3);
            input.Add(4);
            input.Add(5);
            input.Add(6);
            ListInt expected = new ListInt();
            input.Add(1);
            input.Add(2);
            input.Add(3);
            input.Add(4);
            input.Add(5);
            input.Add(6);

            // Act
            ListInt result = BubbleSort.Sort(input);

            // Assert
            Assert.AreEqual(expected.ToString(), result.ToString());
        }

        [TestMethod]
        public void BubbleSort_HandlesReverseSortedArray()
        {
            // Arrange
            ListInt input = new ListInt();
            input.Add(6);
            input.Add(5);
            input.Add(4);
            input.Add(3);
            input.Add(2);
            input.Add(1);
            ListInt expected = new ListInt();
            input.Add(6);
            input.Add(5);
            input.Add(4);
            input.Add(3);
            input.Add(2);
            input.Add(1);

            // Act
            ListInt result = BubbleSort.Sort(input);

            // Assert
            Assert.AreEqual(expected.ToString(), result.ToString());
        }

        [TestMethod]
        public void BubbleSort_HandlesArrayWithDuplicates()
        {
            // Arrange
            ListInt input = new ListInt();
            input.Add(5);
            input.Add(5);
            input.Add(5);
            input.Add(1);
            input.Add(5);
            input.Add(6);
            ListInt expected = new ListInt();
            input.Add(5);
            input.Add(5);
            input.Add(5);
            input.Add(1);
            input.Add(5);
            input.Add(6);

            // Act
            ListInt result = BubbleSort.Sort(input);

            // Assert
            Assert.AreEqual(expected.ToString(), result.ToString());
        }
    }
}
