using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.ArraysEks.EnumEks
{
    internal class PersonE
    {
        public PersonEnums Status { get; set; }
        public PersonE(string? Navn)
        {
            if (Navn == "Abdo")
                Status = PersonEnums.Teacher;
            else
                Status = PersonEnums.Unknown;
        }
        public void SetPersonPrincipal()
        {

        }
    }
}
