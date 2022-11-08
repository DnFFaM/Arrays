using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExamples.Codes
{
    internal class WordCount
    {
        public int Count()
        {
            string? tekst =
            "public: The type or member can be accessed by any other code in the same assembly or another assembly that references it. The accessibility level of public members of a type is controlled by the accessibility level of the type itself." +
            "private: The type or member can be accessed only by code in the same class or struct." +
            "protected: The type or member can be accessed only by code in the same class, or in a class that is derived from that class." +
            "internal: The type or member can be accessed by any code in the same assembly, but not from another assembly. In other words, internal types or members can be accessed from code that is part of the same compilation." +
            "protected internal: The type or member can be accessed by any code in the assembly in which it's declared, or from within a derived class in another assembly." +
            "private protected: The type or member can be accessed by types derived from the class that are declared within its containing assembly.";

            string[] tekstSplit = tekst.Split(' ');



            //Eksempel med for loop
            int c = 0;
            for (int x = 0; x < tekstSplit.Length; x++)
            {
                if (tekstSplit[x].ToLower().Contains("type"))
                {
                    c++;
                }
            }

            // Eksempel med foreach loop
            // lav som foreach loop her...
            //foreach()

            // Eksempel med while loop
            // lav som while loop her...
            //while(true)
            //{

            //}

            return c;
        }
    }
}
