using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace WebApiDemo
{
    public class PersonsControllerIntegrationTests
    {
        private readonly TestServer _server;
        private readonly HttpClient _client;

        public PersonsControllerIntegrationTests()
        {
            // Arrange
            _server = new TestServer(new WebHostBuilder()
                                     .UseStartup<Startup>());
            TestServer _server1 = _server;
          //  _client = _server1.CreateClient();
        }
        
    }
}
