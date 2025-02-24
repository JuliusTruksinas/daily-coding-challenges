namespace DailyCodingChallenges.src
{
    /*
        An isogram is a word that has no repeating letters, consecutive or non-consecutive.
        Implement a function that determines whether a string that contains only letters is an isogram.
        Assume the empty string is an isogram. Ignore letter case.

        Example:
        "Dermatoglyphics" --> true
        "aba" --> false
        "moOse" --> false (ignore letter case)
    */

    public static class Isograms
    {
        public static void Run()
        {
            Console.WriteLine("'Dermatoglyphics' is an isogram: " + IsIsogram("Dermatoglyphics"));
            Console.WriteLine("'aba' is an isogram: " + IsIsogram("aba"));
            Console.WriteLine("'moOse' is an isogram: " + IsIsogram("moOse"));
        }

        public static bool IsIsogram(string word)
        {
            var usedLetters = new HashSet<char>();
            return !word.ToLower().Any(letter => !usedLetters.Add(letter));
        }
    }
}