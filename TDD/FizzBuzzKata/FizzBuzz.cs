using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD.FizzBuzzKata
{
    class FizzBuzz
    {
        public static string PrintWord(int i)
        {
            var flags = WordType.None;

            if (IsFizz(i))
                flags |= WordType.Fizz;

            if (IsBuzz(i))
                flags |= WordType.Buzz;

            switch (flags)
            {
                case WordType.Fizz:
                    return "Fizz";
                case WordType.Buzz:
                    return "Buzz";
                case WordType.Fizz | WordType.Buzz:
                    return "FizzBuzz";
                default:
                    return i.ToString();
            }
        }

        private static bool IsFizz(int i)
        {
            return i % 3 == 0;
        }
        private static bool IsBuzz(int i)
        {
            return i % 5 == 0;
        }
    }
}
