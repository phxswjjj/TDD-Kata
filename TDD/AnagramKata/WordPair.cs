using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD.AnagramKata
{
    public class WordPair
    {
        private List<string> _words = new List<string>();
        private WordPair(string key)
        {
            this.Key = key;
        }
        public WordPair(string key, string w1, string w2)
            : this(key)
        {
            this.Word1 = w1;
            this.Word2 = w2;

            this._words.Add(w1);
            this._words.Add(w2);

            this.SortWords();
        }
        public WordPair(string key, params string[] words)
            : this(key)
        {
            if (words.Length > 0)
                this.Word1 = words[0];
            if (words.Length > 1)
                this.Word2 = words[1];

            this._words.AddRange(words);

            this.SortWords();
        }

        private void SortWords()
        {
            this._words.Sort();
        }

        public string Key { get; private set; }
        public string Word1 { get; set; }
        public string Word2 { get; set; }
        public List<string> Words
        {
            get
            {
                return _words;
            }
        }
    }
}
