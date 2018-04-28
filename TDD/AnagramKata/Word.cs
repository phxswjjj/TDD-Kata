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
        }
        public string Source { get; private set; }
        public string Key { get; private set; }
    }
}
