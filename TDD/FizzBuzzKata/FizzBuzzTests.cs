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
        [DataTestMethod]
        [DataRow(1, "1")]
        [DataRow(2, "2")]
        [DataRow(3, "Fizz")]
        [DataRow(4, "4")]
        [DataRow(5, "Buzz")]
        [DataRow(6, "Fizz")]
        [DataRow(14, "14")]
        [DataRow(15, "FizzBuzz")]
        [DataRow(16, "16")]
        public void TestNumber(int i, string result)
        {
            Assert.AreEqual(result, FizzBuzz.PrintWord(i));
        }
    }
}
