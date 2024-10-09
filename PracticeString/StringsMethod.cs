using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PracticeString
{
    internal class StringsMethod
    {
        public string ReverseString(string str)
        {
            int left = 0;
            int right = str.Length - 1;

            StringBuilder sb = new StringBuilder(str);

            while (left < right)
            {
                char temp = sb[left];
                sb[left] = sb[right];
                sb[right] = temp;
                left++;
                right--;
            }
            return sb.ToString();
        }

        public string ReverseSentenceWithoutChangingPunc(string str)
        {
            string separators = @"[.,:;=()&\[\]""'\\\/!? ]+";

            string[] words = Regex.Split(str, separators);

            MatchCollection separatorIX = Regex.Matches(str, separators);

            List<string> wordlist = new List<string>();
            foreach (string word in words)
            {
                if (!string.IsNullOrEmpty(word))
                    wordlist.Add(word);
            }

            wordlist.Reverse();

            string result = "";
            int wordIX = 0;

            foreach (Match separator in separatorIX)
            {
                if (wordIX < wordlist.Count)
                {
                    result += wordlist[wordIX];
                    wordIX++; 
                }
                result += separator.Value;
                
            }

            return result;
        }

        public List<string> ExtractPalindromes(string text)
        {
            string separators = @"[.,:;=\(\)&\[\]""'\\\\/!? ]";

            string[] words = Regex.Split(text, separators);
            List<string> wordlist = new List<string>();
            foreach (string word in words)
            {
                if (!string.IsNullOrEmpty(word) && IsPalindrome(word))
                    wordlist.Add(word);
            }
            wordlist.Sort();

            return wordlist;
        }

        // check whether the word is palindrome
        public bool IsPalindrome(string word)
        {
            int left = 0;
            int right = word.Length - 1;

            while (left < right)
            {
                if (word[left] != word[right])
                    return false;
                left++; 
                right--;
            }
            return true;
        }

        public void ParseUrl(string url)
        {
            string pattern = @"^(?:(?<protocol>[a-zA-Z][a-zA-Z\d+\-.]*):\/\/)?(?<server>[^\/]+)(?:\/(?<resource>.*))?$";

            Match match = Regex.Match(url, pattern);

            if (match.Success)
            {
                string protocol = match.Groups["protocol"].Value;
                string server = match.Groups["server"].Value;
                string resource = match.Groups["resource"].Value;

                Console.WriteLine("[protocol] = " + (string.IsNullOrEmpty(protocol) ? "\"\"" : "\"" + protocol + "\""));
                Console.WriteLine("[server] = " + "\"" + server + "\"");
                Console.WriteLine("[resource] = " + (string.IsNullOrEmpty(resource) ? "\"\"" : "\"" + resource + "\""));
            }
            else
            {
                Console.WriteLine("Invalid URL format.");
            }
        }
    }
}
