using System;

namespace SweetNSalty
{
    class SweetNSalty
    {
        static void Main(string[] args)
        {
            int sweet = 3;
            int salty = 5;
            
            sweetOrSalty(sweet, salty);
        }
        public static void sweetOrSalty(int sweet, int salty)
        {
            for(int i = 0; i <= 990; i += 10)
            {
                for(int j = 1; j <= 10; j++)
                {
                    if((i+j)%3 == 0 && (i+j)%5 == 0)
                    {
                        Console.Write("Sweet n' Salty ");
                    }else if((i+j)%3 == 0)
                    {
                        Console.Write("Sweet ");
                    }else if((i+j)%5 == 0)
                    {
                        Console.Write("Salty ");
                    }else{
                        Console.Write((i+j) + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
