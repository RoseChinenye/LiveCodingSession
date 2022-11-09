using System;

namespace LiveCodingSession
{
    public static class MaskedString
    {
        internal static void StringMasker()
        {
            Console.WriteLine("Enter Word: ");
            string Input = Console.ReadLine();

           int Unmasked = 4;
            if(Input.Length <= Unmasked)
            {
                Console.WriteLine(Input);
                Console.WriteLine("There is nothing to mask");
            }
            else
            {

             string ShowString(string OriginalString, int lastDigit)
            {
                string Result = new String('#', OriginalString.Length - lastDigit) + 
                        OriginalString.Substring(OriginalString.Length - lastDigit);
                return Result;
            }
            Console.WriteLine(ShowString(Input, Unmasked));
         }
     }
  }
}
