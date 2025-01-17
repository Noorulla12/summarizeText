﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace summarizeText
{
    public class StringUtility
    {
        public static string SummarizingText(string Text, int maxLength = 20)
        {

            if (Text.Length < maxLength)
                return Text;

            var words = Text.Split(' ');
            var totalCharacters = 0;
            var summaryWords = new List<string>();

            foreach (var word in words)
            {
                summaryWords.Add(word);
                totalCharacters += word.Length + 1;
                if (totalCharacters > maxLength)
                    break;
            }
            return string.Join(" ", summaryWords) + "....";

        }
    }
}
