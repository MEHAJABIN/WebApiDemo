using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiDemo.Models;

namespace WebApiDemo.Controllers
{
    public class PersonService : Person
    {
        public PersonService()
        {
        }

        public object Add(Person model)
        {
            throw new NotImplementedException();
        }

       /* public object Add(Person model)
        {
            throw new NotImplementedException();
        }*/

        public object Add(PersonsController.Person model)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public object GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }

        public void Update(int id, PersonsController.Person model)
        {
            throw new NotImplementedException();
        }

        internal object Get(int v)
        {
            throw new NotImplementedException();
        }
    }
}

