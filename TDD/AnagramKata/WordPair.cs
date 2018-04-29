using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD.AnagramKata
{
    public class WordPair
    {
        public WordPair(string w1, string w2)
        {
            this.Word1 = w1;
            this.Word2 = w2;

            var combinedWord = new Word($"{w1}{w2}");
            this.Key = combinedWord.Key;
        }

        public string Key { get; private set; }
        public string Word1 { get; set; }
        public string Word2 { get; set; }
    }
}
