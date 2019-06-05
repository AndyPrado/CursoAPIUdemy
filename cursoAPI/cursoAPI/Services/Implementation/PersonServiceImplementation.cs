using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cursoAPI.Models;

namespace cursoAPI.Services.Implementation
{
    public class PersonServiceImplementation : IPersonService
    {
        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(int id)
        {            
        }

        public List<Person> FindAll()
        {
            List<Person> persons = new List<Person>();

            for(int i = 0; i < 8; i++)
            {
                Person person = Fake(i);
                persons.Add(person);
            }
            return persons;
        }

        public Person FindById(int personId)
        {
            return Fake(1);
        }

        public Person Update(Person person)
        {
            return person;
        }

        public Person Fake(int i)
        {
            Person fakePerson = new Person
            {
                Id = i,
                FirstName = "Anderson",
                LastName = "Prado",
                Address = "Teste",
                Gender = "Masculino"
            };


            return fakePerson;
        }
    }
}
