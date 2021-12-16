using System.Collections.Generic;
using System.Linq;

namespace Module3HW4
{
    public class Task1
    {
        public void Run()
        {
            var contacts = new List<Contact>
            {
                new Contact()
                {
                    FirstName = "Dima",
                    SecondName = "Yampolskyi",
                    Number = "+380008142950",
                    Age = 50
                },
                new Contact()
                {
                    FirstName = "Vadim",
                    SecondName = "Biliy",
                    Number = "+380008142950",
                    Age = 67
                },
                new Contact()
                {
                    FirstName = "Roma",
                    SecondName = "Momot",
                    Number = "+245008142950",
                    Age = 13
                },
                new Contact()
                {
                    FirstName = "Dima",
                    SecondName = "Menshakov",
                    Number = "+380008142950",
                    Age = 20
                },
                new Contact()
                {
                    FirstName = "Serhiy",
                    SecondName = "Naimitenko",
                    Number = "+380008142950",
                    Age = 18
                },
                new Contact()
                {
                    FirstName = "Drugolek",
                    SecondName = "Drugolek",
                    Number = "+777008142950",
                    Age = 50
                }
            };

            var firstDima = contacts.FirstOrDefault(item => item.FirstName == "Dima");
            var older18 = contacts.Where(item => item.Age > 18);
            var secondNames = contacts.Select(item => item.SecondName);
            var older20 = contacts.Any(item => item.Age > 20);
            var older30 = contacts.Count(item => item.Age > 30);
            var grouped = contacts.GroupBy(item => item.FirstName);
        }
    }
}