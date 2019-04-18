using System.Collections.Generic;
using static WebApiDemo.Controllers.PersonsController;

namespace WebApiDemo.Controllers
{
    public interface IPersonService2
    {
        object Add(Person model);
        Person Add();
        void Delete(int id);
        void Delete();
        Person Get(int id);
        object All { get; }

        IEnumerable<Person> GetAll();
        void Update();
        void Update(int id, Person person);
    }
}