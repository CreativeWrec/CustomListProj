using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;
namespace CustomListUnitTesting
{
    [TestClass]
    public class AddTesting
    {
        [TestMethod]
        public void Add_AddTwoValues_CountOf2()
        {
            //arrange

            CustomList<int> customList = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int expected = 2;
            int actual;

            //act
            customList.Add(value1);
            customList.Add(value2);
            actual = customList.Count;

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_AddTwoValues_CapacityOf4()
        {
            //arrange

            CustomList<int> customList = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int expected = 4;
            int actual;

            //act
            customList.Add(value1);
            customList.Add(value2);
            actual = customList.Capacity;

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_FourValues_CountEqualFour()
        {
            //arrange
            CustomList<int> customList = new CustomList<int>();
            int value1 = 2;
            int value2 = 16;
            int value3 = 21;
            int value4 = 50;
            int expected = 4;
            int actual;

            //act
            customList.Add(value1);
            customList.Add(value2);
            customList.Add(value3);
            customList.Add(value4);
            actual = customList.Count;

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_ThreeValues_CheckingThirdValue()
        {
            //arrange
            CustomList<int> customList = new CustomList<int>();
            int value1 = 10;
            int value2 = 20;
            int value3 = 30;
            int expected = 30;
            int actual;

            //act
            customList.Add(value1);
            customList.Add(value2);
            customList.Add(value3);
            actual = customList[2];
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_FourValues_CheckingTotalCapacity()
        {
            //arrange
            CustomList<int> customList = new CustomList<int>();
            int value1 = 55;
            int value2 = 26;
            int value3 = 66;
            int value4 = 11;
            int expected = 4;
            int actual;

            //act
            customList.Add(value1);
            customList.Add(value2);
            customList.Add(value3);
            customList.Add(value4);
            actual = customList.Capacity;

            //assert
            Assert.AreEqual(expected, actual);
        }

    }
}
