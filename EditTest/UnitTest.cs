using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Edit.Edit;

namespace EditTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void IsOneEdit_abc_abc_ReturnedTrue()
        {
            //arrange
            string str1 = "abc";
            string str2 = "abc";
            bool expected = true;

            //act
            bool actual = IsOneEdit(str1, str2);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsOneEdit_abc_adbc_ReturnedTrue()
        {
            //arrange
            string str1 = "abc";
            string str2 = "adbc";
            bool expected = true;

            //act
            bool actual = IsOneEdit(str1, str2);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsOneEdit_adbc_abc_ReturnedTrue()
        {
            //arrange
            string str1 = "adbc";
            string str2 = "abc";
            bool expected = true;

            //act
            bool actual = IsOneEdit(str1, str2);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsOneEdit_abc_ac_ReturnedTrue()
        {
            //arrange
            string str1 = "abc";
            string str2 = "ac";
            bool expected = true;

            //act
            bool actual = IsOneEdit(str1, str2);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsOneEdit_ac_abc_ReturnedTrue()
        {
            //arrange
            string str1 = "ac";
            string str2 = "abc";
            bool expected = true;

            //act
            bool actual = IsOneEdit(str1, str2);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsOneEdit_a_abc_ReturnedFalse()
        {
            //arrange
            string str1 = "a";
            string str2 = "abc";
            bool expected = false;

            //act
            bool actual = IsOneEdit(str1, str2);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsOneEdit_abc_a_ReturnedFalse()
        {
            //arrange
            string str1 = "abc";
            string str2 = "a";
            bool expected = false;

            //act
            bool actual = IsOneEdit(str1, str2);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsOneEdit_abc_abde_ReturnedFalse()
        {
            //arrange
            string str1 = "abc";
            string str2 = "abde";
            bool expected = false;

            //act
            bool actual = IsOneEdit(str1, str2);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsOneEdit_null_abc_ThrowArgumentNullException()
        {
            //arrange
            string str1 = null;
            string str2 = "abc";

            //act + assert
            Assert.ThrowsException<ArgumentNullException>(() => IsOneEdit(str1, str2));
        }
    }
}