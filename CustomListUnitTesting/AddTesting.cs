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
      
    }
}
