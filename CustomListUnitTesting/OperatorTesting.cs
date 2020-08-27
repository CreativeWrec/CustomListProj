using System;
using CustomList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomListUnitTesting
{
    [TestClass]
    public class OperatorTesting
    {
        [TestMethod]
        public void Overload_PlusOperator_CountIsSix()
        {
            //arrange
            CustomList<int> customListOne = new CustomList<int>();
            customListOne.Add(1); // 0
            customListOne.Add(3); // 1
            customListOne.Add(5); // 2


            CustomList<int> customListTwo = new CustomList<int>();
            customListOne.Add(2); // 3
            customListOne.Add(4); // 4
            customListOne.Add(6); // 5


            CustomList<int> result = customListOne + customListTwo;
            int expected = 6;
            int actual;

            //act
            actual = result.Count;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Overload_MinusOverload_CountIsTwo()
        {
            //arrange
            CustomList<int> customListOne = new CustomList<int>();
            customListOne.Add(1);
            customListOne.Add(3);
            customListOne.Add(5);


            CustomList<int> customListTwo = new CustomList<int>();
            customListTwo.Add(2);
            customListTwo.Add(1);
            customListTwo.Add(6);


            CustomList<int> results = customListOne - customListTwo; // { 3, 5 }
            
            int expected = 2;


            int actual;

            //act

            actual = results.Count;

            //assert
            Assert.AreEqual(expected, actual);
        }
             
    }
}
