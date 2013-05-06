using System;
using System.Threading.Tasks;
using System.Web.Mvc;
using AdS.Commands;
using AdS.Commands.Campaign;
using AdS.Commands.Search;

namespace BootstrapMVC.Controllers
{
    public class ExampleController : Controller
    {
        //Note: This is example code, in production you probably 
        //want inject the command handler with an IOC container
        private readonly CommandHandler _commandhandler = 
            new CommandHandler(() => new HttpClientConfiguration(new Uri("http://devservices.adnet.adlibris.se", UriKind.Absolute)));

        public async Task<ActionResult> Index()
        {
            var result = await _commandhandler.Execute(new GetCampaignsCommand());
            return View(result.Result);
        }
    }
}