using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3HW4
{
    public class Contact
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Number { get; set; }
        public int Age { get; set; }
        public string FullName => $"{FirstName} {SecondName}";
    }
}