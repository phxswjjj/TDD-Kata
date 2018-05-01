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
        [DataTestMethod]
        [DataRow("", 'a', 0)]
        [DataRow("abbccc", 'x', 0)]
        [DataRow("abbccc", 'a', 1)]
        [DataRow("abbccc", 'b', 2)]
        [DataRow("abbccc", 'c', 3)]
        public void TestCharFreq(string word, char c, int exceptCharFreq)
        {
            var w = new Word(word);
            Assert.AreEqual(exceptCharFreq, w.GetCharFreq(c));
        }
    }
}
