using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _04_Methods
{
    [TestClass]
    public class MethodExamples
    {
        // Input
        // What we do
        // Output

        //access modifier(public)...return type(void)...method signuratur-name and list of parameter(TestMethod1)

        public int AddTwoNumbers(int numOne, int numTwo)
        {
            int sum = numOne + numTwo;
            return sum;
        }

        private int SubtractTwoNumbers(int a, int b)
        {
            int num = a - b;
            return num;
        }

        private int MultiplyTwoNumbers(int x, int z)
        {
            int prod = x * z;
            return prod;
        }

        private int DivideTwoNumbers(int peanut, int butter)
        {
            int jelly = peanut / butter;
            return jelly;
        }

        private int FindRemainder(int a, int numTwo)
        {
            int remainder = a % numTwo;
            return remainder;
        }


        [TestMethod]
        public void MethodTests()
        {
            int banana = AddTwoNumbers(7, 12);
            Assert.AreEqual(19, banana);

            int subtractedBanana = SubtractTwoNumbers(10, 5);
            Assert.AreEqual(5, subtractedBanana);



        }


    }
}

