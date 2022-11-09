global using Arrays.ArraysEks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.ArraysEks.Models
{
    internal class Person : IStudent
    {
        public PersonModel PersonData { get; set; }

        public Person(PersonModel personData)
        {
            PersonData = personData;
        }
    }
}
