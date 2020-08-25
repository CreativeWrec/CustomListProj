using System;
using CustomList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomListUnitTesting
{
    [TestClass]
    public class RemoveTesting
    {
        [TestMethod]
        public void Remove_FivePositiveValuesRemoveOne_CheckingCount()
        {
            //arrange
            CustomList<int> customList = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;
            int expected = 4;
            int actual;
            //act
            customList.Add(value1);
            customList.Add(value2);
            customList.Add(value3);
            customList.Add(value4);
            customList.Add(value5);
            customList.Remove(value1);
            actual = customList.Count;
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_()
        {
            //arrange
            CustomList<int> customList = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;
            int expected = 2;
            int actual;
            //act
            customList.Add(value1);
            customList.Add(value2);
            customList.Add(value3);
            customList.Add(value4);
            customList.Add(value5);
            customList.Remove(value1);
            actual = customList.Count;
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_()
        {
            //arrange
            CustomList<int> customList = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;
            int expected = 4;
            int actual;
            //act
            customList.Add(value1);
            customList.Add(value2);
            customList.Add(value3);
            customList.Add(value4);
            customList.Add(value5);
            customList.Remove(value1);
            actual = customList.Count;
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_()
        {
            //arrange
            CustomList<int> customList = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;
            bool expected = false;
            bool actual;
            //act
            customList.Add(value1);
            customList.Add(value2);
            customList.Add(value3);
            customList.Add(value4);
            customList.Add(value5);
            customList.Remove(value1);
            actual = customList[100];
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_()
        {
            //arrange
            CustomList<int> customList = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;
            bool expected = true;
            bool actual;
            //act
            customList.Add(value1);
            customList.Add(value2);
            customList.Add(value3);
            customList.Add(value4);
            customList.Add(value5);
            customList.Remove(value1);
            actual = customList[4];
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
