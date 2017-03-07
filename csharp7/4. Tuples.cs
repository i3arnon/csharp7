using System.Collections.Generic;
using static System.Console;

namespace csharp7
{
    static class Tuples
    {
        static Dictionary<string, int> _cache = new Dictionary<string, int>();

        class CacheResult
        {
            public bool IsExists { get; set; }
            public int Result { get; set; }
        }

        static CacheResult Old(string key)
        {
            int result;
            var isExists = _cache.TryGetValue(key, out result);

            return new CacheResult
            {
                IsExists = isExists,
                Result = result,
            };
        }

        static (bool isExists, int result) New(string key)
        {
            int result;
            var isExists = _cache.TryGetValue(key, out result);

            return (false, 32);
        }

        static void Foo()
        {
            // Fake names
            var a = New("a");
            WriteLine(a.result);
            WriteLine(a.Item1);            // No names
            (bool, long) b = New("b");
            WriteLine(b.Item2);

            // Tuple rename
            (bool doesExist, int result) c = New("c");
            WriteLine(c.result);

            // Variable deconstruction
            (bool doesExist, var result) = New("d");
            WriteLine(doesExist);

            // Deconstruction inference
            var (DoesExist, Result) = New("e");
            WriteLine(DoesExist);
        }
    }
}
