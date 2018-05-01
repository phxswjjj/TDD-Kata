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
            var filterChars = destWord.ToArray();
            var filteredSources = from s in sources
                                  where s.IndexOfAny(filterChars) != -1
                                  select s;

            var compareWord = new Word(destWord);
            var results = new List<WordPair>();
            var sourcesCount = filteredSources.Count();
            for (var i = 0; i < sourcesCount - 1; i++)
            {
                for (var j = i + 1; j < sourcesCount; j++)
                {
                    var wp = new WordPair(filteredSources.ElementAt(i), filteredSources.ElementAt(j));
                    var bAllCharMatched = true;
                    foreach (var charFreq in compareWord.CharFrequences)
                    {
                        if (charFreq.Value > wp.GetCharFreq(charFreq.Key))
                        {
                            bAllCharMatched = false;
                            break;
                        }
                    }
                    if (bAllCharMatched)
                        results.Add(wp);
                }
            }
            return results;
        }
    }
}
