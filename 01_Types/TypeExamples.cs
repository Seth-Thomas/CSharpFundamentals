using System;
using System.Collections.Generic;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_Types
{
    [TestClass]
    public class TypeExamples
    {
        [TestMethod]
        public void ValueTypes()
        {
            // Whole Numbers
            byte oneBytesWorth;
            oneBytesWorth = 255;
            short smallWholeNumber = 16; //Int16
            Int16 anotherSmallNumber = 16;
            int wholeNumber = 32; //Int32
            long largeWholeNumber = 64; //Int64

            int newNumber = oneBytesWorth;

            //Decimals
            float floatExample = 1.2346f;
            double doubleExample = 1.23345d;
            decimal decimalExample = 1.2345m;

            //type  //name(label)  //value
            char letter = 'j';


            //Operators
            int numOne = 17;
            int numTwo = 5;

            int sum = numOne + numTwo;
            Console.WriteLine(sum);
            int diff = numOne - numTwo;
            Console.WriteLine(diff); //Answer is 3 in the test run because its an integer/whole number
            int prod = numOne * numTwo;
            Console.WriteLine(prod);
            int quot = numOne / numTwo;
            Console.WriteLine(quot);
            int remainder = numOne % numTwo;
            Console.WriteLine(remainder);

            Console.WriteLine("Hello");

        }
        [TestMethod]
        public void ReferenceTypes()
        {
            //Strings
            string stringExample = "This is a string.";
            string name = "Seth";

            string declared;
            declared = "Now it's initialized";

            //Formatting strings
            string concatenate = stringExample + " " + name; //This is a string. Seth
            string interpolate = $"{name}. Here is the string {stringExample}."; //Seth. Here is the string: This is a string.
            Console.WriteLine(concatenate);
            Console.WriteLine(interpolate);

            //--Other Object Examples
            DateTime now = DateTime.Now;
            Console.WriteLine(now);

            DateTime randomDate = new DateTime(2020, 11, 11);

            TimeSpan waitTime = randomDate - now;
            Console.WriteLine(waitTime.TotalSeconds);

            //--Collections
            //Arrays
            string anotherExampleString = "Hello World";
            string[] stringArray = { anotherExampleString, "Hello", "World", "!" };
            string[] students = new string[15];

            Console.WriteLine(stringArray);

            //Lists
            List<string> listOfStrings = new List<string>();
            listOfStrings.Add("Lawrence");

            //Queues
            Queue<string> firstInFirstOut = new Queue<string>();
            firstInFirstOut.Enqueue("Luke");

            //Dictionaries
            Dictionary<char, string> keyValuePair = new Dictionary<char, string>();
            keyValuePair.Add('j', "Seth");

            //Other Collections
            SortedList<int, string> sortedKeyValuePair = new SortedList<int, string>();
            Stack<string> firstInLastOut = new Stack<string>();
        }

        [TestMethod]
        public void MyTestMethod()
        {
            int age = 23;

            if (age <= 18)

            {

                Console.WriteLine($"You are: {age}.");

            }

            else if (age > 18 && age <= 35)

            {

                Console.WriteLine($"How are you? You are: {age}.");

            }

            else

            {

                Console.WriteLine("...");

            }
        }
    }
}

