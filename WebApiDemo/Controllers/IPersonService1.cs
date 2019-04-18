using System.Collections.Generic;
using static WebApiDemo.Controllers.PersonsController;

namespace WebApiDemo.Controllers
{
    public interface IPersonService1
    {
        object Add(Person model);

        void Delete(int id);


        Person Get(int id);
        object All { get; }

        IEnumerable<Person> GetAll();

        void Update(Person model, int id);

        void Update(int id, Person person);
    }
}