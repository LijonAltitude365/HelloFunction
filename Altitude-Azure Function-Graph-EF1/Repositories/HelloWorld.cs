using Altitude_Azure_Function_Graph_EF1.ServiceContracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Altitude_Azure_Function_Graph_EF1.Repositories
{
    public class HelloWorld : IHelloWorld
    {
        public async Task<string> GetString()
        {
            return "Hello DI";
        }
    }
}
