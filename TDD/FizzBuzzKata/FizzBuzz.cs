using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD.FizzBuzzKata
{
    class FizzBuzz
    {
        public static string PrintFizzBuzz()
        {
            var results = new List<string>();
            for(var i = 1; i <= 100; i++)
                results.Add(PrintWord(i));
            return string.Join(" ", results);
        }
        public static string PrintWord(int i)
        {
            if (!IsValidNumber(i))
                throw new ArgumentOutOfRangeException($"entered number is {i}, which should be between 1 to 100");

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

        private static bool IsValidNumber(int i)
        {
            return i >= 1 && i <= 100;
        }
        private static bool IsFizz(int i)
        {
            return i % 3 == 0 || i.ToString().Contains("3");
        }
        private static bool IsBuzz(int i)
        {
            return i % 5 == 0 || i.ToString().Contains("5");
        }
    }
}
