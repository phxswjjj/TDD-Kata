using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD.FizzBuzzKata
{
    [Flags]
    public enum WordType
    {
        None = 0,
        Fizz = 1,
        Buzz = 1 << 1
    }
}
