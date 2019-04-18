using static WebApiDemo.Controllers.PersonsController;

namespace WebApiDemo.Controllers
{
    internal interface IPersonService
    {
        object GetAll();
        object Add(Person model);
        void Update(int id, PersonsController.Person model);
        void Delete(int id);
       // object Add(PersonsController.Person model);
    }
}