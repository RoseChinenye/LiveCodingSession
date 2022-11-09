using System;

namespace LiveCodingSession
{
    public static class CapitalLetterIndex
    {
        internal static void CheckCapitalLetter()
        {
            Console.WriteLine("Enter a word or sentence: ");
            string Input = Console.ReadLine();

            List<int> IndexOfString = new List<int>();

            int k;
            for (int k = 0; k < Input.Length; k++)
            {
                if (Input[k] >= 'A' & Input[k] <= 'Z') 
                {
                    IndexOfString.Add(k);
                }
                else
                {
                    Console.WriteLine("Capital Letters doesn't exist.");
                }
            }

            foreach (int k in IndexOfString)
            {
                Console.WriteLine($"Index: {k}\t Value: {Input[k]}");
            }
        }
    }
}
