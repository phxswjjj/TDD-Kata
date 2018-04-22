using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD.FizzBuzzKata
{
    [TestClass]
    public class FizzBuzzTests
    {
        string _result;

        [TestInitialize]
        public void Init()
        {
            _result = "1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz Fizz 14 FizzBuzz 16 17 Fizz 19 Buzz Fizz 22 Fizz Fizz Buzz 26 Fizz 28 29 FizzBuzz Fizz Fizz Fizz Fizz FizzBuzz Fizz Fizz Fizz Fizz Buzz 41 Fizz Fizz 44 FizzBuzz 46 47 Fizz 49 Buzz FizzBuzz Buzz FizzBuzz FizzBuzz Buzz Buzz FizzBuzz Buzz Buzz FizzBuzz 61 62 Fizz 64 Buzz Fizz 67 68 Fizz Buzz 71 Fizz Fizz 74 FizzBuzz 76 77 Fizz 79 Buzz Fizz 82 Fizz Fizz Buzz 86 Fizz 88 89 FizzBuzz 91 92 Fizz 94 Buzz Fizz 97 98 Fizz Buzz";
        }

        [DataTestMethod]
        [DataRow(1, "1")]
        [DataRow(2, "2")]
        [DataRow(3, "Fizz")]
        [DataRow(4, "4")]
        [DataRow(5, "Buzz")]
        [DataRow(6, "Fizz")]
        [DataRow(13, "Fizz")]
        [DataRow(14, "14")]
        [DataRow(15, "FizzBuzz")]
        [DataRow(16, "16")]
        [DataRow(53, "FizzBuzz")]
        public void TestNumber(int i, string result)
        {
            Assert.AreEqual(result, FizzBuzz.PrintWord(i));
        }

        [DataTestMethod]
        [DataRow(-1)]
        [DataRow(0)]
        [DataRow(101)]
        public void TestInvalidNumber(int i)
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => FizzBuzz.PrintWord(i));
        }
        
        [TestMethod]
        public void TestPrintFizzBuzz()
        {
            Assert.AreEqual(_result, FizzBuzz.PrintFizzBuzz());
        }
    }
}
