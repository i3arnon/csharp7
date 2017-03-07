using static System.Console;

namespace csharp7
{
    static class Switch
    {
        static void Old(Animal animal)
        {
            if (animal is Hamster)
            {
                var hamster = (Hamster)animal;
                WriteLine(hamster.TeethLength);
            }
            else if (animal is Bunny)
            {
                var bunny = (Bunny)animal;
                if (bunny.EarLength > 10)
                {
                    WriteLine($"Big Ears: {bunny.EarLength}");
                }
                else
                {
                    WriteLine(bunny.EarLength);
                }
            }
            else
            {
                WriteLine("Unexpected animal");
            }
        }

        static void New(Animal animal)
        {
            // Order matters
            switch(animal)
            {
                case Hamster hamster:
                    WriteLine(hamster.TeethLength);
                    break;
                case Bunny bunny when (bunny.EarLength > 10):
                    WriteLine($"Big Ears: {bunny.EarLength}");
                    break;
                // But not for default
                default:
                    WriteLine("Unexpected animal");
                    break;
                case Bunny bunny:
                    WriteLine(bunny.EarLength);
                    break;
            }
        }
    }
}
