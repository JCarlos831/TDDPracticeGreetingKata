using System;
using System.Collections;
using NUnit.Framework;

namespace Greeting.Library.Tests
{
    [TestFixture]
    public class GreetingTests
    {
        [Test]
        public void SimpleGreetingWithOneName()
        {
            var name = "Bob";
            var output = Greeting.Greet(name);
            var expectedResult = "Hello, Bob";
            
            Assert.AreEqual(expectedResult, output);
        }

        [Test]
        public void SimpleGreetingWithNoName()
        {
            var output = Greeting.Greet();
            var expectedResult = "Hello, my friend";
            
            Assert.AreEqual(expectedResult, output);
        }

        [Test]
        public void ShoutingWhenAllCaps()
        {
            var shoutingName = "JERRY";
            var output = Greeting.Greet(shoutingName);
            var expectedResult = "HELLO JERRY!";
            
            Assert.AreEqual(expectedResult, output);
        }

        [Test]
        public void GreetingWithTwoNames()
        {
            string[] twoNames = {"Jill", "Jane"};
            var output = Greeting.Greet(twoNames);
            var expectedResult = "Hello, Jill and Jane.";
            
            Assert.AreEqual(expectedResult, output);
        }

        [Test]
        public void GreetingWithMultipleNames()
        {
            string[] multipleNames = {"Amy", "Brian", "Charlotte"};
            var output = Greeting.Greet(multipleNames);
            var expectedResult = "Hello, Amy, Brian, and Charlotte.";
            
            Assert.AreEqual(expectedResult, output);
        }
        
        [Test]
        public void GreetingWithMultipleMixedNames()
        {
            string[] multipleNames = {"Amy", "BRIAN", "Charlotte"};
            var output = Greeting.Greet(multipleNames);
            var expectedResult = "Hello, Amy and Charlotte. AND HELLO BRIAN!";
            
            Assert.AreEqual(expectedResult, output);
        }
    }
}