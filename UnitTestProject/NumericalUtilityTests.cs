using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using UtilityLibrary;

namespace UnitTestProject
{
    [TestClass]
    public class NumericalUtilityTests
    {
        [TestMethod]
        public void IsNaturalNumberTrue()
        {
            // arrange
            string entryData = "48";
            bool expected = true;

            // act
            bool actual = NumericalUtility.IsNaturalNumber(entryData);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsNaturalNumberFalse()
        {
            // arrange
            string entryData = "-48";
            bool expected = false;

            // act
            bool actual = NumericalUtility.IsNaturalNumber(entryData);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsDividerTrue()
        {
            // arrange
            int dividend = 27;
            int divider = 9;
            bool expected = true;

            // act
            bool actual = NumericalUtility.IsDivider(dividend, divider);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsDividerFalse()
        {
            // arrange
            int dividend = 27;
            int divider = 7;
            bool expected = false;

            // act
            bool actual = NumericalUtility.IsDivider(dividend, divider);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DivisorsNumbersSuccess()
        {
            // arrange
            int number = 20;
            IList<int> expected = new List<int>() { 1, 2, 4, 5, 10, 20 };
            bool isEqual = true;

            // act
            var actual = NumericalUtility.DivasorNumbers(number);
            foreach (var item in expected)
            {
                if (!isEqual) break;
                if (actual.IndexOf(item) == -1)
                {
                    isEqual = false;
                }
            }

            // assert
            Assert.IsTrue(isEqual);
        }

        [TestMethod]
        public void DivisorsNumbersFailed()
        {
            // arrange
            int number = 20;
            IList<int> notExpected = new List<int>() { 1, 2, 3, 4, 5, 6, 10, 20 };
            bool isEqual = false;

            // act
            var actual = NumericalUtility.DivasorNumbers(number);
            foreach (var item in notExpected)
            {
                if (!isEqual) break;
                if (actual.IndexOf(item) == -1)
                {
                    isEqual = true;
                }
            }

            // assert
            Assert.IsFalse(isEqual);
        }

        [TestMethod]
        public void EvenDividersTrue()
        {

            // arrange
            int number = 20;
            IList<int> expected = new List<int>() { 2, 4, 10, 20 };
            bool isEqual = true;

            // act
            var actual = NumericalUtility.EvenDividers(number);
            foreach (var item in expected)
            {
                if (!isEqual) break;
                if (actual.IndexOf(item) == -1)
                {
                    isEqual = false;
                }
            }

            // assert
            Assert.IsTrue(isEqual);
        }

        [TestMethod]
        public void EvenDividersFalse()
        {
            // arrange
            int number = 20;
            IList<int> notExpected = new List<int>() { 1, 2, 3, 4, 5 };
            bool isEqual = false;

            // act
            var actual = NumericalUtility.EvenDividers(number);
            foreach (var item in notExpected)
            {
                if (!isEqual) break;
                if (actual.IndexOf(item) == -1)
                {
                    isEqual = true;
                }
            }

            // assert
            Assert.IsFalse(isEqual);
        }

        [TestMethod]
        public void PrimeDividersTrue()
        {

            // arrange
            int number = 20;
            IList<int> expected = new List<int>() { 2, 4, 10, 20 };
            bool isEqual = true;

            // act
            var actual = NumericalUtility.EvenDividers(number);
            foreach (var item in expected)
            {
                if (!isEqual) break;
                if (actual.IndexOf(item) == -1)
                {
                    isEqual = false;
                }
            }

            // assert
            Assert.IsTrue(isEqual);
        }

        [TestMethod]
        public void PrimeDividersFalse()
        {
            // arrange
            int number = 20;
            IList<int> notExpected = new List<int>() { 1, 2, 3, 4, 5 };
            bool isEqual = false;

            // act
            var actual = NumericalUtility.EvenDividers(number);
            foreach (var item in notExpected)
            {
                if (!isEqual) break;
                if (actual.IndexOf(item) == -1)
                {
                    isEqual = true;
                }
            }

            // assert
            Assert.IsFalse(isEqual);
        }
    }
}
