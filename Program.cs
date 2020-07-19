using System;

namespace sashaLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            int adata = 2;
            int addat = 4;
            int datta = 8;
            int drata = 16;
            int datata = 32;

            if (datata - addat == 16)
            {
                Console.WriteLine(datta + adata);
                Console.ReadLine();
            }
            else if (addat > 5)
            {
                Console.WriteLine(datata + drata);
                Console.ReadLine();
            }
            else if (datata + drata > 50)
            {
                Console.WriteLine((datta * 2) - datta - adata );
                Console.ReadLine();
            }
            else if (datta + drata - adata == 22)
            {
                Console.WriteLine(adata * 8 - datta);
                Console.ReadLine();
            }
            else if (datta + adata < drata)
            {
                Console.WriteLine(datta);
                Console.ReadLine();
            }
            else if (drata == 2 + 2 + 2 + 2 + 2 + 2 + 2)
            {
                Console.WriteLine(datta);
                Console.ReadLine();
            }
        }
    }
}
