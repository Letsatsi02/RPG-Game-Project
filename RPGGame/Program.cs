class Program
{
    static void Main(string[] args)
    {
        Warrior warrior = new Warrior("Warrior");
        Mage mage = new Mage("Mage");

        warrior.Attack(mage);
        mage.Fireball(warrior);
        warrior.Slash(mage);
        mage.Attack(warrior);
    }
}

class Program
{
    static void Main(string[] args)
    {
        LongestSubstring longestSubstring = new LongestSubstring();
        Console.WriteLine(longestSubstring.LengthOfLongestSubstring("abcabcbb")); // 3
        Console.WriteLine(longestSubstring.LengthOfLongestSubstring("bbbbb")); // 1
        Console.WriteLine(longestSubstring.LengthOfLongestSubstring("pwwkew")); // 3
    }
}