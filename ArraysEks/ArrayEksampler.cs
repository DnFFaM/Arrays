using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class MutiDimensionalArray
{
    public string[] ArrayTest()
    {
        string? result = null;

        string[] h1Fag = { "Studieteknik", "Grund.prog.", "OOP" };
        string[] h2Fag = { "OOP2", "Database server", "Clientside prog. 2" };

        string[][] fagene = { h1Fag, h2Fag };

        string[,] fagene2D = new string[2, 3]
        {
            { "Studieteknik", "Grund.prog.", "OOP" },
            { "OOP2", "Database server", "Clientside prog. 2" }
        };

        result = fagene2D[1, 2];
        string[] aa = new string[6];
        int c = 0;
        for (int k = 0; k < 2; k++)
        {
            for (int l = 0; l < 3; l++)
            {
                aa[c] = fagene2D[k, l];
                c++;
            }
        }



        return aa;
    }
}
