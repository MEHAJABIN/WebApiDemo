using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiDemo.Controllers;
using static WebApiDemo.Controllers.PersonsController;

namespace WebApiDemo
{
    public class PersonsControllerUnitTests
    {
        private static object person;

        public object AssertionExtensions { get; private set; }

        [Fact]
        public void Values_Get_All()
        {
            // Arrange
            var controller = new PersonsController(new PersonService());

            // Act
            var result = controller.Get();

            // Assert
            /* var okResult = result.Should().BeOfType<OkObjectResult>().Subject;
             var persons = okResult.Value.Should().BeAssignableTo<IEnumerable<Person>>().Subject;

             persons.Count().Should().Be(50);*/
        }

        [Fact]
        public void Values_Get_Specific()
        {
            // Arrange
            var controller = new PersonsController(new PersonService());

            // Act
            object p = GetP(controller);
            var result = p;

            // Assert
            /*  var okResult = result.Should().BeOfType<OkObjectResult>().Subject;
              var person = okResult.Value.Should().BeAssignableTo<Person>().Subject;
              person.Id.Should().Be(16);*/
        }

        private object GetP(PersonsController controller)
        {
            throw new NotImplementedException();
        }

        /*  private static object GetP(PersonsController controller)
           {
               PersonsController controller1 = controller;
               PersonsController controller11 = controller1;
               // return await NewMethod(controller11);
           }*/

        private static IActionResult NewMethod(PersonsController controller1)
        {
            return controller1.Get(16);
        }

        [Fact]
        public void Persons_Add()
        {
            // Arrange
            var controller = new PersonsController(new PersonService());
            var newPerson = new Person
            {
                FirstName = "John",
                LastName = "Doe",
                Age = 50,
                Title = "FooBar",
                Email = "john.doe@foo.bar"
            };

            // Act
            var result = controller.Post(newPerson);

            // Assert
            /*    var okResult = result.Should().BeOfType<CreatedAtActionResult>().Subject;
                var person = okResult.Value.Should().BeAssignableTo<Person>().Subject;
                person.Id.Should().Be(51);*/
        }

        [Fact]
        public void Persons_Change()
        {
            // Arrange
            var service = new PersonService();
            var controller = new PersonsController(service);
            var newPerson = new Person
            {
                FirstName = "John",
                LastName = "Doe",
                Age = 50,
                Title = "FooBar",
                Email = "john.doe@foo.bar"
            };

            // Act
            var result = controller.Put(20, newPerson);

            // Assert
            //  NewMethod2(result);

            NewMethod1(service);
            /*   NewMethod(person);
               NewMethod1(person);
               NewMethod3(person);
               NewMethod4(person);
             //  NewMethod5(person);
               NewMethod6(person);*/
        }

        private static void NewMethod1(PersonService service)
        {
            var person = service.Get(20);
        }

        private static void NewMethod6(object person)
        {
            NewMethod7(person);
        }

        private static void NewMethod7(object person)
        {
            NewMethod8();
        }

        private static void NewMethod8()
        {
            NewMethod10();
        }

        private static void NewMethod10()
        {
            NewMethod11();
        }

        private static void NewMethod11()
        {
            throw new NotImplementedException();
        }

        //  private static void NewMethod11()
        /*  {
              person.NewMethod5.Should().Be("john.doe@foo.bar");
          }*/

        //   private static void NewMethod5(object person) => NewMethod9(person);

        /*   private static void NewMethod9(object person)
           {
               person.Title.Should().Be("FooBar");
           }*/

        private static void NewMethod4(object person)
        {
            NewMethod12(person);
        }

        private static void NewMethod12(object person)
        {
            NewMethod12(person);
        }

        /*private static void NewMethod11(object person)
        {
            NewMethod13(person);
        }*/

        /*  private static void NewMethod13(object person)
          {
              person.Age.Should().Be(50);
          }*/

        /*  private static void NewMethod3(object person)
          {
              NewMethod5(person);
          }

          private static void NewMethod5(object person)
          {
              NewMethod9(person);
          }

         private static void NewMethod9(object person) => person.LastName.Should().Be("Doe");

          private static void NewMethod2(IActionResult result)
          {
              var okResult = result.Should().BeOfType<NoContentResult>().Subject;
          }

          private static void NewMethod1(object person) => person.FirstName.Should().Be("John");

          private static void NewMethod(object person)
          {
              person.Id.Should().Be(20);
          }*/

        [Fact]
        public void Persons_Delete()
        {
            // Arrange
            var service = new PersonService();
            var controller = new PersonsController(service);

            // Act
            /*   object result = await NewMethod(controller);

               // Assert
               NewMethod1(result);
               NewMethod2(service);
           }

           private void NewMethod2(PersonService service)
           {

               // should throw an eception, 
               // because the person with id==20 doesn't exist enymore
           /*    AssertionExtensions.ShouldThrow<InvalidOperationException>(
                 () => service.Get(20));*/
        }

        /* private static void NewMethod1(object result)
         {
             NewMethod3(result);
         }

         private static void NewMethod3(object result)
         {
             NewMethod5(result);
         }

         private static void NewMethod5(object result)
         {
             NewMethod9(result);
         }

         private static void NewMethod9(object result)
         {
             NewMethod11(result);
         }

         private static void NewMethod11(object result)
         {
             var okResult = result.Should().BeOfType<NoContentResult>().Subject;
         }

         private static async Task<object> NewMethod(PersonsController controller)
         {
             return await controller.Delete(20);
         }
         */
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
