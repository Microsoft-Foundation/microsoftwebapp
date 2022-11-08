﻿namespace MicrosoftWebApp
{
    public class SomeLogic
    {
        /// <summary>
        /// Array Sorting method added
        /// </summary>
        /// <returns></returns>
        int ArraySorting()
        {
            int[] numbers = new int[] { 3, 5, 7, 1, 2 };
            Array.Sort(numbers);
            return numbers[0];
        }

        /// <summary>
        /// Find last word in string
        /// </summary>
        /// <param name="sentence"></param>
        /// <returns></returns>
        string FindLastWord(string sentence)
        {
            string[] words = sentence.Split(' ');
            return words[words.Length - 1];
        }
    }
}