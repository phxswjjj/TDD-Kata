using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD.AnagramKata
{
    public class WordPair
    {
        Word _word = null;
        public WordPair(string w1, string w2)
        {
            this.Word1 = w1;
            this.Word2 = w2;

            _word = new Word($"{w1}{w2}");
        }
        public int GetCharFreq(char c)
        {
            return _word.GetCharFreq(c);
        }

        public string Key { get { return _word.Key; } }
        public string Word1 { get; set; }
        public string Word2 { get; set; }
        public Dictionary<char, int> CharFrequences { get { return _word.CharFrequences; } }
    }
}
