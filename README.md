# LazySliceExtentions
Lazy Slice Extentions

## Usage
example 1
```c#
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        IEnumerable<int> foo = Enumerable.Empty<int>()
           .Append(1)
           .Append(2)
           .Append(3)
           .Append(4)
           .Append(5)
           .Append(6)
           .Append(7)
           .Append(8)
           .Append(9)
           .Append(10);

        int sum = foo.Aggregate(0, (a, b) => a + b);
        var s = foo.Select(x => x.ToString()).Aggregate("", (a, b) => "" == a ? $"{b}" : $"{a}+{b}");

        Trace.WriteLine($"{sum}={s}");
    }
}
```
> 55=1+2+3+4+5+6+7+8+9+10

example 2
```c#
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        IEnumerable<int> bar = Enumerable.Empty<int>();

        foreach (var n in Enumerable.Range(1, 100))
        {
            bool divable = false;
            foreach (var d in Enumerable.Range(1, n - 1))
            {
                if (1 == d)
                    continue;

                divable = 0 == n % d;
                if (divable == true)
                    break;
            }
            if (!divable)
                bar = bar.Append(n);
        }

        Trace.WriteLine($"{bar.Select(x => x.ToString()).Aggregate("", (a, b) => "" == a ? $"{b}" : $"{a},{b}")}");
    }
}
```
> 1,2,3,5,7,11,13,17,19,23,29,31,37,41,43,47,53,59,61,67,71,73,79,83,89,97
