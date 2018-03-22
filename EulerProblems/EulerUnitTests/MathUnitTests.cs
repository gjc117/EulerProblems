using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace EulerUnitTests
{
    
    [TestClass]
    public class MathUnitTests
    {
        MathMethods mm = new MathMethods();

        [TestMethod]
        public void PrimeNumberIsPrime_true()
        {
            // arrange  
            double x = 13;

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

            // act  
            bool actual = mm.isPalindrome(x);

            // assert  
            bool expected = false;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void numberOfDivisors_pass()
        {
            //arrange
            int x = 20;

            //act
            int actual = mm.numberOfDivisors(x);

            //assert
            int expected = 6;
            Assert.AreEqual(expected, actual);
            
        }

        [TestMethod]
        public void Collatz_pass()
        {
            //arrange
            int x = 13;

            //act
            int actual = mm.Collatz(x);

            //assert
            int expected = 10;
            Assert.AreEqual(expected, actual);
      
        }

    }
}
