using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using System.Net.Http;
using System.Diagnostics;
using Altitude_Azure_Function_Graph_EF1.ServiceContracts;
using Altitude_Azure_Function_Graph_EF1.Settings;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Altitude_Azure_Function_Graph_EF1
{
    public class HellOFunction
    {
        private readonly ApplicationSettings _appSettings;
        private readonly IHelloWorld _helloContext;

        public HellOFunction(IOptions<ApplicationSettings> appSettings, IHelloWorld helloContext)
        {
            _appSettings = appSettings.Value;
            _helloContext = helloContext;
        }

        [FunctionName("ManualAdminTest")]
        public async Task<IActionResult> RunManualTest([HttpTrigger(AuthorizationLevel.Anonymous, methods: "get", Route = null)]HttpRequest req, ILogger log)
        {
            log.LogWarning($"Function initialized successfully at {DateTime.UtcNow}");

            if (_appSettings.MySetting != null)
                return new OkObjectResult(_appSettings.MySetting);

            return new OkObjectResult(_helloContext.GetString());
        }
    }
}
