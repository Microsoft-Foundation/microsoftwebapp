namespace MicrosoftWebApp
{
    public class SomeLogic
    {
        /// <summary>
        /// Array Sorting method added
        /// </summary>
        /// <returns></returns>
        int ArraySorting()
        {
            // Let me correct the business logic here - fixed
            int[] numbers = new int[] { 3, 5, 7, 1, 2 };
            string str = "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";
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
            // Let me correct the business logic here - fixed
            string[] words = sentence.Split(' ');
            return words[words.Length - 1];
        }

        /// <summary>
        /// Binary search method implemented
        /// </summary>
        void BinarySearch()
        {
            // Let me correct the business logic here - fixed
            int[] numbers = new int[] { 3, 5, 7, 1, 2 };
            Array.Sort(numbers);
            int index = Array.BinarySearch(numbers, 5);
        }
    }
}
