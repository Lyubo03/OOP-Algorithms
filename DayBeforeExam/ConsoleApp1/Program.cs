using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([:]{2}|[*]{2})(?<name>[A-Za-z]{3,})\1";
            Regex emoji = new Regex(pattern);
            string numPattern = @"[\d]";
            Regex numRegex = new Regex(numPattern);
            string text = Console.ReadLine();
            MatchCollection matchEmoji = emoji.Matches(text);
            MatchCollection matchNums = numRegex.Matches(text);
            long coolHolder = 1;
            int[] num = matchNums.Select(x => int.Parse(x.Value)).ToArray();
            foreach (var item in num)
            {
                coolHolder *= item;
            }
            Console.WriteLine($"Cool threshold: {coolHolder}");
            Console.WriteLine($"{matchEmoji.Count} emojis found in the text. The cool ones are:");
            foreach (Match item in matchEmoji)
            {
                string emojiToDigits = item.Groups["name"].Value;
                long emojiCoolnes = EmojiCoolness(emojiToDigits);
                if (emojiCoolnes >= coolHolder)
                {
                    Console.WriteLine(item);
                }
            }
        }
        static long EmojiCoolness(string emoji)
        {
            long emojiCoolness = 0;
            for (int i = 0; i < emoji.Length; i++)
            {
                emojiCoolness += emoji[i];
            }
            return emojiCoolness;
        }
    }
}
