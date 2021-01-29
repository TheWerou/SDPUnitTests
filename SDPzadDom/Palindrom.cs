using System;
using System.Text.RegularExpressions;

namespace SDPzadDom
{
    public class Palindrom
    {
        public string TextToAnalize { get; set; }
        public bool IsPalindrom { get; set; }

        public Palindrom(string? text=null)
        {
            if(text != null)
            {
                TextToAnalize = text;
                IsPalindrom = AnalizeText(TextToAnalize);
            }

        }
        private string PrepText(string text)
        {
            text = text.Replace(".", "");
            text = text.Replace("!", "");
            text = text.Replace("?", "");
            text = text.Replace(",", "");
            text = text.Replace("(", "");
            text = text.Replace(")", "");
            text = text.Replace("_", "");
            text = Regex.Replace(text, @"\s+", "");
            text = text.ToLower();
            return text;
        }
        public bool AnalizeText(string text)
        {
            text = PrepText(text);
            string reversedText;
            

            char[] charArray = text.ToCharArray();
            Array.Reverse(charArray);
            reversedText = new string(charArray);

            if (text != reversedText || text.Length < 1)
            {
                IsPalindrom = false;
                return false;
            }
            else
            {
                IsPalindrom = true;
                return true;
            }

        }

    }
}
