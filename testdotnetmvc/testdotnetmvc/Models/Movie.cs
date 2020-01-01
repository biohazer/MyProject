using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(testdotnetmvc.Models.Movie))]

namespace testdotnetmvc.Models
{
    public class Movie
    {
        public void Configuration(IAppBuilder app)
        {
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=316888
        }

        private int Id { get; set; }
        private string Name { get; set; }
    }
}
