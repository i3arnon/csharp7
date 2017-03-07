using static System.Console;

namespace csharp7
{
    class Animal
    {
        public string Name { get; set; }
    }

    class Hamster : Animal
    {
        public int TeethLength { get; set; }
    }

    class Bunny : Animal
    {
        public int EarLength { get; set; }
    }

    static class IsExpression
    {
        static void Old(Animal animal)
        {
            if (animal is Hamster)
            {
                var hamster = animal as Hamster;
                WriteLine(hamster.TeethLength);
            }
            else if (animal is Bunny)
            {
                var bunny = (Bunny)animal;
                WriteLine(bunny.EarLength);
            }
        }

        static void New(Animal animal)
        {
            if (animal is Hamster hamster)
            {
                WriteLine(hamster.TeethLength);
            }
            else if (animal is Bunny bunny)
            {
                WriteLine(bunny.EarLength);
            }
        }
    }
}
