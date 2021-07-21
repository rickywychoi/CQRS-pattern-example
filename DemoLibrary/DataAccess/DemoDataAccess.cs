using DemoLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.DataAccess
{
    public class DemoDataAccess : IDataAccess
    {
        const int ASCII_UPPER_A = 65;
        const int ASCII_LOWER_Z = 122;
        const int REPEAT_TIMES = 10;

        private List<Person> _people = new();

        public DemoDataAccess()
        {
            for (int i = 0; i < 50; i++)
            {
                _people.Add(new Person
                {
                    Id = i + 1,
                    FirstName = new String((char)(ASCII_UPPER_A + i), REPEAT_TIMES),
                    LastName = new String((char)(ASCII_LOWER_Z - i), REPEAT_TIMES)
                }
                );;
            }
        }

        public List<Person> GetPeople()
        {
            return _people;
        }

        public Person InsertPerson(string firstName, string lastName)
        {
            Person p = new()
            {
                Id = _people.Max(p => p.Id) + 1,
                FirstName = firstName,
                LastName = lastName
            };
            _people.Add(p);
            return p;
        }
    }
}
