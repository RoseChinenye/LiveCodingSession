using System;

namespace LiveCodingSession
{
    internal class breakAndcontinue
    {
        public static void breakAndContinueCode()
        {
           for (int i = 0; i < 20; i++)
           {
            if (i == 5)
            {
                break;
            }
            Console.WriteLine(i);
           }

           for (int j = 0; j < 20; j++)
           {
            if (j == 5)
            {
                continue;
            }
            Console.WriteLine(j);
           }


        }
    }
}
