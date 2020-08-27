using System;
using System.Reflection;
using CustomList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomListUnitTesting
{
    [TestClass]
    public class ToStringTesting
    {
        [TestMethod]
        public void ToString_MultipleValues()
        {
            //arrange
            CustomList<int> customList = new CustomList<int>();
            string expected = "12345";
            string actual;

            //act
            customList.Add(1);
            customList.Add(2);
            customList.Add(3);
            customList.Add(4);
            customList.Add(5);

            actual = customList.ToString();

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ToString_CovertStringValue()
        {
            //arrange
            CustomList<int> customList = new CustomList<int>();
            string expected = "20";
            string actual;

            //act
            customList.Add(20);

            actual = customList.ToString();

            //assert
            Assert.AreEqual(expected, actual);

        }

    }
}
