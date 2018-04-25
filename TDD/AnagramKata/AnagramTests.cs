using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD.AnagramKata
{
    [TestClass]
    public class AnagramTests
    {
        List<string> _sources;
        [TestInitialize]
        public void Init()
        {
            _sources = new List<string>()
            {
                "abc", "bac"
            };
        }

        [TestMethod]
        public void TestEmptySource()
        {
            var results = Anagram.GetResult(new List<string>());
            Assert.AreEqual(0, results.Count);
        }
        [TestMethod]
        public void TestNullSource()
        {
            Assert.ThrowsException<ArgumentNullException>(() => Anagram.GetResult(null));
        }
        [DataTestMethod]
        [DataRow(1, "abc,cba")]
        [DataRow(1, "abc,cba,efg")]
        [DataRow(1, "abc,cba,efg,bca")]
        [DataRow(2, "abc,cba,efg,bca,feg")]
        [DataRow(2, "abc,cba,efg,bca,feg,fegg")]
        public void TestLessSource(int matchCount, string csv)
        {
            var results = Anagram.GetResult(csv.Split(','));
            Assert.AreEqual(matchCount, results.Count);
        }
    }
}
