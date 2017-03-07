using System;
using static System.Console;

namespace csharp7
{
    class KeyValuePair<TKey, TValue>
    {
        public TKey Key { get; set; }
        public TValue Value { get; set; }

        public KeyValuePair(TKey key, TValue value)
        {
            Key = key;
            Value = value;
        }

        public void Deconstruct(out TKey key, out TValue value)
        {
            key = Key;
            value = Value;
        }
    }

    static class Deconstructors
    {
        static KeyValuePair<int, string> GetValue(int key) =>
            new KeyValuePair<int, string>(key, key.ToString());

        static void Foo()
        {
            var _ = DateTime.UtcNow;

            KeyValuePair<int, string> pair = GetValue(0xFF_0A);
            WriteLine(pair.Value);
            
            var (_, value) = GetValue(0b1101_0000_1111);
            WriteLine(value);

            WriteLine(_);
        }
    }
}
