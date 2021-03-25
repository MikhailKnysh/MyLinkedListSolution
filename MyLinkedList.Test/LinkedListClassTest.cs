using NUnit.Framework;
using System;

namespace MyLinkedList.Test
{
    public class LinkedListClassTest : MyListBase
    {
        public override void AddByIndex_WhenInpuIsNotValid_ShouldThrowIndexOutOfRangeException(int index, int value, int[] result)
        {
            throw new System.NotImplementedException();
        }

        public override void AddByIndex_WhenInputIsValid_ShouldAddItToCollection(int index, int valueToInsert, int[] inputArray, int[] expectedArray)
        {
            throw new System.NotImplementedException();
        }

        public override void AddRangeByIndex_WhenInpuISValued_ShouldThrowArgumentException(int index, int[] insertCollection, int[] inputArray)
        {
            throw new System.NotImplementedException();
        }

        public override void AddRangeByIndex_WhenInputIsValued_ShouldAddItToCollection(int index, int[] collectionToInsert, int[] inputArray, int[] expectedArray)
        {
            throw new System.NotImplementedException();
        }

        public override void AddRangeStart_WhenInputIsValued_ShouldAddItToCollection(int[] collectionToInsert, int[] inputArray, int[] expectedArray)
        {
            throw new System.NotImplementedException();
        }

        public override void AddRange_WhenInputIsValued_ShouldAddItToCollection(int[] collectionToInsert, int[] inputArray, int[] expectedArray)
        {
            throw new System.NotImplementedException();
        }

        public override void Add_WhenInputIsValid_ShouldAddItToCollection(int valueToInsert, int[] inputArray, int[] expectedArray)
        {
            throw new System.NotImplementedException();
        }

        [TestCase(-2, 0, new int[] { -2, 34, 5, 6, -2, 57, 68, 65, -2, -17 })]
        public override void FindIndexByValue_WhenValidIndexPassed_ShouldReturnIndex(
            int value, int expectedIndex, int[] inputArray)
        {
            LinkedListClass<int> list = new LinkedListClass<int>(inputArray);
            int actualIndex = list.FindIndexByValue(value);

            Assert.AreEqual(expectedIndex, actualIndex);
        }

        public override void GetMaxIndex_WhenInputIsNotValid_ShouldThrowInvalidOperationExeption(int[] inputArray)
        {
            throw new System.NotImplementedException();
        }

        public override void GetMaxIndex_WhenInputIsNotValid_ShouldThrowNullReferenceExeption(int[] inputArray)
        {
            throw new System.NotImplementedException();
        }

        public override void GetMaxIndex_WhenInputIsValued_ShouldFindIndexMaxElement(int expectedIndex, int[] inputArray)
        {
            throw new System.NotImplementedException();
        }

        public override void GetMax_WhenInputIsValued_ShouldFindMaxElement(int expectedMax, int[] inputArray)
        {
            throw new System.NotImplementedException();
        }

        public override void GetMinIndex_WhenInputIsNotValid_ShouldThrowInvalidOperationInvalidOperationExeption(int[] inputArray)
        {
            throw new System.NotImplementedException();
        }

        public override void GetMinIndex_WhenInputIsNotValid_ShouldThrowNullReferenceExeption(int[] inputArray)
        {
            throw new System.NotImplementedException();
        }

        public override void GetMinIndex_WhenInputIsValid_ShouldFindIndexMinElement(int expectedIndex, int[] inputArray)
        {
            throw new System.NotImplementedException();
        }

        public override void GetMin_WhenInputIsValued_ShouldFindMaxElement(int expectedMin, int[] inputArray)
        {
            throw new System.NotImplementedException();
        }

        public override void HalfReverse_WhenValidListPassed_ShouldReverseListByHalves(int[] inputArray, int[] expectedArray)
        {
            throw new System.NotImplementedException();
        }

        public override void HalfReverse_WhenValidListPassed_ShouldReverseListByHalves(int[] inputArray)
        {
            throw new System.NotImplementedException();
        }

        [TestCase(-1, new int[] { -2, 34, 5, 6 })]
        [TestCase(4, new int[] { -2, 34, 5, 6 })]
        [TestCase(10, new int[] { -2, 34, 5, 6 })]
        public override void RemoveByIndex_WhenIndexOutOfRange_ShouldThrowIndexOutOfRangeException(
            int index, int[] inputArray)
        {
            LinkedListClass<int> actualList = new LinkedListClass<int>(inputArray);

            Assert.Throws<IndexOutOfRangeException>(() => actualList.RemoveByIndex(index));
        }

        public override void RemoveByIndex_WhenIndexOutOfRange_ShouldThrowIndexOutOfRangeException(int index, int quantity, int[] inputArray)
        {
            throw new System.NotImplementedException();
        }

        public override void RemoveByIndex_WhenIndexOutOfRange_ShouldThrowInvalidOperationException(int index, int quantity, int[] inputArray)
        {
            throw new System.NotImplementedException();
        }

        public override void RemoveByIndex_WhenIndexOutOfRange_ShouldThrowInvalidOperationException(int quantity, int[] inputArray)
        {
            throw new System.NotImplementedException();
        }

        [TestCase(0, -2, new int[] { -2, 34, 5, 6, 57, 68, 65, -17 }, new int[] { 34, 5, 6, 57, 68, 65, -17 })]
        [TestCase(1, 34, new int[] { -2, 34, 5, 6, 57, 68, 65, -17 }, new int[] { -2, 5, 6, 57, 68, 65, -17 })]
        [TestCase(6, 65, new int[] { -2, 34, 5, 6, 57, 68, 65, -17 }, new int[] { -2, 34, 5, 6, 57, 68, -17 })]
        [TestCase(7, -17, new int[] { -2, 34, 5, 6, 57, 68, 65, -17 }, new int[] { -2, 34, 5, 6, 57, 68, 65 })]
        public override void RemoveByIndex_WhenValidIndexPassed_ShouldDeleteElementByPosition(
            int index, int expectedValueToRemove, int[] inputArray, int[] expectedArray)
        {
            LinkedListClass<int> actualList = new LinkedListClass<int>(inputArray);
            LinkedListClass<int> expectedList = new LinkedListClass<int>(expectedArray);

            int actualValueToRemove = actualList.RemoveByIndex(index);

            Assert.AreEqual(expectedValueToRemove, actualValueToRemove);
            CollectionAssert.AreEqual(expectedList, actualList);
        }

        public override void RemoveByValueAll_WhenValidIndexPassed_ShouldRemoveFirstValue(int valueToRemove, int expectedCounter, int[] inputArray, int[] expectedArray)
        {
            throw new System.NotImplementedException();
        }

        public override void RemoveByValueFirst_WhenValidIndexPassed_ShouldRemoveFirstValue(int valueToRemove, int expectedIndex, int[] inputArray, int[] expectedArray)
        {
            throw new System.NotImplementedException();
        }

        public override void RemoveRangeByIndex_WhenValidIndexPassed_ShouldRemoveRangeByIndex(int index, int quantity, int[] inputArray, int[] expectedArray)
        {
            throw new System.NotImplementedException();
        }

        public override void RemoveRangeStart_WhenValidIndexPassed_ShouldRemoveRangeStart(int quantity, int[] inputArray, int[] expectedArray)
        {
            throw new System.NotImplementedException();
        }

        [Test]
        public override void RemoveStart_WhenListIsEmpty_ShouldThrowNullReferenceException()
        {
            LinkedListClass<int> inputList = new LinkedListClass<int>() { };

            Assert.Throws<NullReferenceException>(() => inputList.RemoveStart());
        }

        [TestCase(-2, new int[] { -2, 34, 5, 6, 57, 68, 65, -17 }, new int[] { 34, 5, 6, 57, 68, 65, -17 })]
        [TestCase(34, new int[] { 34, 96 }, new int[] { 96 })]
        [TestCase(-117, new int[] { -117 }, new int[] { })]
        public override void RemoveStart_WhenListIsValid_ShouldDeleteFirstElement(
            int expectedValueToRemove, int[] inputArray, int[] expectedArray)
        {
            LinkedListClass<int> actualList = new LinkedListClass<int>(inputArray);
            LinkedListClass<int> expectedList = new LinkedListClass<int>(expectedArray);

            int actualValueToRemove = actualList.RemoveStart();

            Assert.AreEqual(expectedValueToRemove, actualValueToRemove);
            CollectionAssert.AreEqual(expectedList, actualList);
        }

        [Test]
        public override void Remove_WhenListIsEmpty_ShouldThrowNullReferenceException()
        {
            LinkedListClass<int> actualList = new LinkedListClass<int>();

            Assert.Throws<NullReferenceException>(() => actualList.Remove());
        }

        [TestCase(-17, new int[] { 2, 34, 5, 6, 57, 68, 65, -17 }, new int[] { 2, 34, 5, 6, 57, 68, 65 })]
        [TestCase(34, new int[] { 2, 34 }, new int[] { 2 })]
        [TestCase(2, new int[] { 2 }, new int[] { })]
        public override void Remove_WhenListIsValid_ShouldDeleteLastElement(
            int expectedValueToRemove, int[] inputArray, int[] expectedArray)
        {
            LinkedListClass<int> actualList = new LinkedListClass<int>(inputArray);
            LinkedListClass<int> expectedList = new LinkedListClass<int>(expectedArray);

            int actualValueToRemove = actualList.Remove();

            Assert.AreEqual(expectedValueToRemove, actualValueToRemove);
            CollectionAssert.AreEqual(expectedList, actualList);
        }

        public override void Reverse_WhenValidListPassed_ShouldReverseList(int[] inputArray, int[] expectedArray)
        {
            throw new System.NotImplementedException();
        }

        public override void SortDesc_WhenCollectionIsUnsorted_ShouldSortCollectionInDescendingOrder(int[] inputArray, int[] expectedArray)
        {
            throw new System.NotImplementedException();
        }

        public override void Sort_WhenCollectionIsUnsorted_ShouldSortCollectionInAscendingOrder(int[] inpuatArray, int[] expectedArray)
        {
            throw new System.NotImplementedException();
        }

        [TestCase(new int[] { 6, 7, 2, 1, 5, 3, 4, 10, 8, 9 }, "6 7 2 1 5 3 4 10 8 9")]
        public override void ToString_WhenCollectionIsValued_ShouldConvertCollectionToString(
          int[] inputArray, string expectedString)
        {
            LinkedListClass<int> actualList = new LinkedListClass<int>(inputArray);

            string actualString = actualList.ToString();

            Assert.AreEqual(expectedString, actualString);
        }
    }
}