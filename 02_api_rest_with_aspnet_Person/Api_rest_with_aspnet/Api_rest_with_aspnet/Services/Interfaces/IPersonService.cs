using Api_rest_with_aspnet.Model;
using System.Collections.Generic;

namespace Api_rest_with_aspnet.Services
{
    public interface IPersonService
    {
        Person Create(Person person);
        Person FindById(long id);
        List<Person> FindAll();
        Person Update(Person person);
        void Delete(long id);
    }
}
