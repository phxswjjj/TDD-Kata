using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD.AnagramKata
{
    class Anagram
    {
        public static List<WordPair> GetResult(IEnumerable<string> sources)
        {
            var words = from s in sources
                        select new Word(s);
            var gWords = words.GroupBy(w => w.Key);

            var results = new List<WordPair>();
            foreach (var gWord in gWords)
            {
                if (gWord.Count() > 1)
                {
                    var wp = new WordPair(gWord.Key, (from w in gWord select w.Source).ToArray());
                    results.Add(wp);
                }
            }
            return results;
        }
    }
}
