namespace DailyCodingChallenges.src
{
    /*
        Check to see if a string has the same amount of 'x's and 'o's.
        The method must return a boolean and be case insensitive.
        The string can contain any char.

        Examples input/output:

        XO("ooxx") => true
        XO("xooxx") => false
        XO("ooxXm") => true
        XO("zpzpzpp") => true // when no 'x' and 'o' is present should return true
        XO("zzoo") => false
    */

    public static class ExesAndOhs
    {
        public static void Run()
        {
            Console.WriteLine("'ooxx' -> " + DoesStringContainEqualXAndO("ooxx") + " should be: " + "true");
            Console.WriteLine("'xooxx' -> " + DoesStringContainEqualXAndO("xooxx") + " should be: " + "false");
            Console.WriteLine("'ooxXm' -> " + DoesStringContainEqualXAndO("ooxXm") + " should be: " + "true");
            Console.WriteLine("'zpzpzpp' -> " + DoesStringContainEqualXAndO("zpzpzpp") + " should be: " + "true");
            Console.WriteLine("'zzoo' -> " + DoesStringContainEqualXAndO("zzoo") + " should be: " + "false");
        }

        public static bool DoesStringContainEqualXAndO(string input)
        {
            char X = 'x';
            char O = 'o';

            int xCount = 0;
            int oCount = 0;

            foreach (var character in input.ToLower())
            {
                if (character == X)
                {
                    xCount++;
                }
                else if (character == O)
                {
                    oCount++;
                }
            }

            return xCount == oCount;
        }
    }
}