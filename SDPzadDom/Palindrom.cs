using System;

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

        public bool AnalizeText(string text)
        {
            string reversedText;
            text = text.Replace(".", "");
            text = text.Replace("!", "");
            text = text.Replace("?", "");
            text = text.Replace(",", "");
            text = text.Replace(" ", "");
            text = text.ToLower();

            char[] charArray = text.ToCharArray();
            Array.Reverse(charArray);
            reversedText = new string(charArray);

            if (text == reversedText)
            {
                IsPalindrom = true;
                return true;
            }
            else
            {
                IsPalindrom = false;
                return false;
            }

        }

    }
}
