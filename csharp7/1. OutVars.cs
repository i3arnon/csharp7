using System.Collections.Concurrent;
using static System.Console;

namespace csharp7
{
    static class OutVars
    {
        static ConcurrentDictionary<int, bool>  _dictionary = new ConcurrentDictionary<int, bool>();

        static void Old()
        {
            bool dummy;
            if (_dictionary.TryRemove(1000000000, out dummy))
            {
                WriteLine(dummy);
            }
            else
            {
                WriteLine(dummy);
            }
        }

        static void New()
        {
            if (_dictionary.TryRemove(10_0000_0000, out var dummy))
            {
                WriteLine(dummy);
            }
            else
            {
                WriteLine(dummy);
            }
        }
    }
}
