using System;

namespace Codewars_December2021
{
    class Program
    {
        // The deaf rats of Hamelin
        // The Pied Piper has been enlisted to play his magical tune and coax all the rats out of town.

        // But some of the rats are deaf and are going the wrong way!

        // Kata Task
        // How many deaf rats are there?

        // Legend
        // P = The Pied Piper
        // O~ = Rat going left
        // ~O = Rat going right

        public static int CountDeafRats(string town)
        {
            var piperOnTheLeft = false;
            var deafRat = 0;
            for (var i = 0; i < town.Length; i++)
            {
                if (town[i] == 'P') piperOnTheLeft = true;
                if (town[i] == 'O')
                {
                    i++;
                    if (!piperOnTheLeft) deafRat++;
                    continue;
                }
                if (town[i] == '~')
                {
                    i++;
                    if (piperOnTheLeft) deafRat++;
                    continue;
                }
            }
            return deafRat;
        }
        static void Main(string[] args)
        {
            CountDeafRats("~O~O~O~O P");
            CountDeafRats("P O~ O~ ~O O~");
        }
    }
}
