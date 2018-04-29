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
            var compareWord = new Word(destWord);
            var results = new List<WordPair>();
            var sourcesCount = sources.Count();
            for (var i = 0; i < sourcesCount - 1; i++)
            {
                for (var j = i + 1; j < sourcesCount; j++)
                {
                    var wp = new WordPair(sources.ElementAt(i), sources.ElementAt(j));
                    if (wp.Key.Equals(compareWord.Key))
                        results.Add(wp);
                }
            }
            return results;
        }
    }
}
