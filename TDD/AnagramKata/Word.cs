using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD.AnagramKata
{
    public class Word
    {
        public Word(string w)
        {
            this.Source = w;

            //bbca to abbc
            var sorted = w.OrderBy(c => c);
            this.Key = string.Join("", sorted);

            this.CharFrequences = new Dictionary<char, int>();
            foreach (var c in this.Key)
            {
                if (this.CharFrequences.ContainsKey(c))
                    this.CharFrequences[c]++;
                else
                    this.CharFrequences.Add(c, 1);
            }
        }
        public int GetCharFreq(char c)
        {
            if (this.CharFrequences.ContainsKey(c))
                return this.CharFrequences[c];
            else
                return 0;
        }

        public string Source { get; private set; }
        public string Key { get; private set; }
        public Dictionary<char, int> CharFrequences { get; private set; }
    }
}
