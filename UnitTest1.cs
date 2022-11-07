using System;
using Xunit;

namespace DemoTesting{
    public class UnitTesting{
        [Fact]
        public void CanReturnString(){
            Assert.Equal("1", FizzBuzz.Convert(1));
        }
        [Fact]
        public void ReturnsFizzForThree(){
            Assert.Equal("Fizz", FizzBuzz.Convert(3));
        }
        [Fact]
        public void ReturnsBuzzForFive(){
            Assert.Equal("Buzz", FizzBuzz.Convert(5));
        }
        [Fact]
        public void ReturnsFizzBuzzForFifteen(){
            Assert.Equal("FizzBuzz", FizzBuzz.Convert(15));
        }
    }
}