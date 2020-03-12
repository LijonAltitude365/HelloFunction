using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Altitude_Azure_Function_Graph_EF1.ServiceContracts
{
    public interface IHelloWorld
    {
        Task<string> GetString(); 
    }
}
