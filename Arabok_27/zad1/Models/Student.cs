using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1.Models
{
    public class Student
    {
        public string LastName {  get; set; }
        public string Birthday {  get; set; }
        public string Name { get; set;}

        public override string ToString()
        {
            return new StringBuilder()
                .AppendLine($"Last name is {LastName}")
                .AppendLine($"\tDate of Birthday is {Birthday}")
                .AppendLine($"\tName is {Name}")
                .ToString();
        }
    }
}
