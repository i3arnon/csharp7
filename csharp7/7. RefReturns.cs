using System;
using static System.Console;

namespace csharp7
{
    static class RefReturns
    {
        static ref int Find(int number, int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == number)
                {
                    return ref numbers[i];
                }
            }

            throw new Exception($"{nameof(number)} not found");
        }

        static void Main()
        {
            int[] array = { 1, 15, -39, 0, 7, 14, -12 };
            ref int slot = ref Find(7, array);
            slot = 9; // replaces 7 with 9 in the array
            WriteLine(array[4]); // prints 9
        }
    }
}
