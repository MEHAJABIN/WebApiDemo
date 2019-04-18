using Microsoft.AspNetCore.Hosting;

namespace WebApiDemo
{
    internal class TestServer
    {
        private IWebHostBuilder webHostBuilder;

        public TestServer(IWebHostBuilder webHostBuilder)
        {
            this.webHostBuilder = webHostBuilder;
        }
    }
}