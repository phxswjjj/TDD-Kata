using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD.AnagramKata
{
    class Anagram
    {
        public static List<WordPair> GetResult(string destWord, IEnumerable<string> sources)
        {
            var words = from s in sources
                        select new Word(s);
            var gWords = words.GroupBy(w => w.Key);

            var results = new List<WordPair>();
            foreach (var gWord in gWords)
            {
                if (gWord.Count() > 1)
                {
                    
                }
            }
            return results;
        }
    }
}
