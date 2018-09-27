using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using B3Next.Clients.Interfaces;

/**
 * https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-2.1
 * https://docs.microsoft.com/en-us/aspnet/core/web-api/index?view=aspnetcore-2.1#annotate-class-with-apicontrollerattribute
 * https://docs.microsoft.com/en-us/aspnet/core/web-api/?view=aspnetcore-2.1
 * https://docs.microsoft.com/en-us/aspnet/core/tutorials/web-api-vsc?view=aspnetcore-2.1
 * https://stackify.com/asp-net-core-web-api-guide/
 */

namespace B3Next.Clients.Web.Controllers
{
    [Route("api/clients")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        public ClientController(IClient client)
        {

        }
    }
}
