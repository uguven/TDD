using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using General;

namespace TEST_TDD
{
    [TestClass]
    public class TestValidator
    {

        [TestMethod]
        public void TestTrueEmail()
        {
            bool result = Validator.ValidateEmail("uguven@gmail.com");
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestTurkeyEmail()
        {
            bool result = Validator.ValidateEmail("uguven@gmail.com.tr");
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestMissedExtention()
        {
            bool result = Validator.ValidateEmail("uguven@gmail");
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void TestWrongextension()
        {
            bool result = Validator.ValidateEmail("uguven@gmail.abcrtyu");
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void TestMissedAtSign()
        {
            bool result = Validator.ValidateEmail("uguvengmail.com");
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void TestEmptyEmail()
        {
            bool result = Validator.ValidateEmail("");
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void TestMultipleEmail()
        {
            bool result = Validator.ValidateEmail("uguven@gmail.com;ugur_guven@hotmail.com");
            Assert.AreEqual(true, result);

            result = Validator.ValidateEmail("u-guven@gmail.com;ugur_guven@hotmail.com");
            Assert.AreEqual(true, result);

            result = Validator.ValidateEmail(".u-guven@gmail.com;ugur_guven@hotmail.com");
            Assert.AreEqual(true, result);
        }

    }
}