using cursoAPI.Models;
using System.Collections.Generic;

namespace cursoAPI.Services
{
    interface IPersonService
    {
        Person Create(Person person);
        Person FindById(int personId);
        List<Person> FindAll();
        Person Update(Person person);
        void Delete(int id);
    }
}
