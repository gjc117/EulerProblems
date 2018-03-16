using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace EulerUnitTests
{
    
    [TestClass]
    public class MathUnitTests
    {
        [TestMethod]
        public void PrimeNumberIsPrime_true()
        {
            // arrange  
            double x = 13;
            MathMethods mm = new MathMethods();

            // act  
            bool actual = mm.isPrime(x);

            // assert  
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PrimeNumberIsPrime_false()
        {
            // arrange  
            double x = 1100;
            MathMethods mm = new MathMethods();

            // act  
            bool actual = mm.isPrime(x);

            // assert  
            bool expected = false;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void isPalindrome_true()
        {
            // arrange  
            double x = 9009;
            MathMethods mm = new MathMethods();

            // act  
            bool actual = mm.isPalindrome(x);

            // assert  
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void isPalindrome_false()
        {
            // arrange  
            double x = 1100;
            MathMethods mm = new MathMethods();

            // act  
            bool actual = mm.isPalindrome(x);

            // assert  
            bool expected = false;
            Assert.AreEqual(expected, actual);
        }
    }
}
