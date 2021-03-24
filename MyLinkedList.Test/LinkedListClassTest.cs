using NUnit.Framework;
using System;

namespace MyLinkedList.Test
{
    public class LinkedListClassTest : MyListBase
    {
        [TestCase(10, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
            new int[] { 10, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 })]
        public void AddStart_WhenInputValue_ShouldAddItToCollection(
           int valueToInsert, int[] inputArray, int[] expectedArray)
        {
            LinkedListClass<int> expectedList = new LinkedListClass<int>(expectedArray);
            LinkedListClass<int> actualList = new LinkedListClass<int>(inputArray);

            actualList.AddStart(valueToInsert);

            CollectionAssert.AreEqual(expectedList, actualList);
        }

        [TestCase(-2, 10, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 })]
        [TestCase(25, 10, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 })]
        public override void AddByIndex_WhenInpuIsNotValid_ShouldThrowIndexOutOfRangeException(int index, int data, int[] result)
        {
            LinkedListClass<int> actualList = new LinkedListClass<int>(result);

            Assert.Throws<IndexOutOfRangeException>(() => actualList.AddByIndex(index, data));
        }

        [TestCase(3, 10, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
            new int[] { 1, 2, 3, 10, 4, 5, 6, 7, 8, 9, 10 })]
        [TestCase(0, 10, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
            new int[] { 10, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 })]
        [TestCase(6, 10, new int[] { 1, 2, 3, 4, 5, 6 }, new int[] { 1, 2, 3, 4, 5, 6, 10 })]
        [TestCase(0, 10, new int[] { }, new int[] { 10 })]
        public override void AddByIndex_WhenInputIsValid_ShouldAddItToCollection(int index, int valueToInsert, int[] inputArray, int[] expectedArray)
        {
            LinkedListClass<int> expectedList = new LinkedListClass<int>(expectedArray);
            LinkedListClass<int> actualList = new LinkedListClass<int>(inputArray);

            actualList.AddByIndex(index, valueToInsert);

            CollectionAssert.AreEqual(expectedList, actualList);
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


        [TestCase(10, new int[] { 1, 2, 3, 4, 5, 6 }, new int[] { 1, 2, 3, 4, 5, 6, 10 })]
        [TestCase(10, new int[] { }, new int[] { 10 })]
        public override void Add_WhenInputIsValid_ShouldAddItToCollection(int valueToInsert, int[] inputArray, int[] expectedArray)
        {
            LinkedListClass<int> expectedList = new LinkedListClass<int>(expectedArray);
            LinkedListClass<int> actualList = new LinkedListClass<int>(inputArray);

            actualList.Add(valueToInsert);

            CollectionAssert.AreEqual(expectedList, actualList);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, new int[] { })]
        [TestCase( new int[] { 1, 2, 3,15 }, new int[] { })]
        public void Clear_WhenIClearCollection_ShouldEmptyCollection( int[] inputArray, int[] expectedArray)
        {
            LinkedListClass<int> expectedList = new LinkedListClass<int>(expectedArray);
            LinkedListClass<int> actualList = new LinkedListClass<int>(inputArray);

            actualList.Clear();

            CollectionAssert.AreEqual(expectedList, actualList);
        }

        public override void FindIndexByValue_WhenValidIndexPassed_ShouldReturnIndex(int valueToInsert, int expectedIndex, int[] inputArray)
        {
            throw new System.NotImplementedException();
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

        public override void RemoveByIndex_WhenIndexOutOfRange_ShouldThrowArgumentOutOfRangeException(int index, int[] inputArray)
        {
            throw new System.NotImplementedException();
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

        public override void RemoveByIndex_WhenValidIndexPassed_ShouldDeleteElementByPosition(int index, int expectedValueToRemove, int[] inputArray, int[] expectedArray)
        {
            throw new System.NotImplementedException();
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

        public override void RemoveStart_WhenIndexOutOfRange_ShouldThrowArgumentOutOfRangeException()
        {
            throw new System.NotImplementedException();
        }

        public override void RemoveStart_WhenValidIndexPassed_ShouldDeleteFirstElement(int expectedValueToRemove, int[] inputArray, int[] expectedArray)
        {
            throw new System.NotImplementedException();
        }

        public override void Remove_WhenIndexOutOfRange_ShouldThrowArgumentOutOfRangeException()
        {
            throw new System.NotImplementedException();
        }

        public override void Remove_WhenValidIndexPassed_ShouldDeleteLastElement(int expectedValueToRemove, int[] inputArray, int[] expectedArray)
        {
            throw new System.NotImplementedException();
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

        public override void ToString_WhenCollectionIsValued_ShouldConvertCollectionToString(int[] inputArray, string expectedString)
        {
            throw new System.NotImplementedException();
        }
    }
}