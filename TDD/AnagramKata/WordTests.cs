using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD.AnagramKata
{
    [TestClass]
    public class WordTests
    {
        [DataTestMethod]
        [DataRow("", "")]
        [DataRow("bca", "abc")]
        [DataRow("bcba", "abbc")]
        [DataRow("aaa", "aaa")]
        [DataRow("bBaAaa", "ABaaab")]
        public void TestWord(string word, string exceptKey)
        {
            var w = new Word(word);
            Assert.AreEqual(exceptKey, w.Key);
        }
    }
}
