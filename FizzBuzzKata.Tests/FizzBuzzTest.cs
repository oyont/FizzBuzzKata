using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text; 
using FluentAssertions;

namespace FizzBuzzKata.Tests
{
    [TestFixture]
    public class FizzBuzzTest
    { 
        private FizzBuzz _sut;

        [SetUp]
        public void TestSetUp()
        {
         _sut = new FizzBuzz();
         
        }
         
        [Test]
        public void FizzBuzz_Should_PrintsOutTheNumbers1Through100()
        {   
            _sut.PrintList().Count.Should().Be(100);
        }

        [TestCase(3)]
        [TestCase(6)]
        [TestCase(9)]
        public void FizzBuzz_Should_PrintFizz_WhenNumberDivisibleBy3(int givenNumber)
        {  
            var result = _sut.GenerateFizzBuzz(givenNumber);

            result.Should().Be("Fizz");
        }
         
        [TestCase(5)]
        [TestCase(10)] 
        public void FizzBuzz_Should_PrintFizz_WhenNumberDivisibleBy5(int givenNumber)
        {  
            var result = _sut.GenerateFizzBuzz(givenNumber);

            result.Should().Be("Buzz");
        }

        [TestCase(15)]
        [TestCase(30)]
        [TestCase(45)]
        public void FizzBuzz_Should_PrintFizz_WhenNumberDivisibleBy3And5(int givenNumber)
        {
            var result = _sut.GenerateFizzBuzz(givenNumber);

            result.Should().Be("PrintList");
        }

    }
}
