using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Web.Models;

namespace Web.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    
    public IActionResult Index()
    {
        var quotes = new Dictionary<string, object>
        {
            {"1", "They had a large chunk of the garbage file? How much do they know?"},
            {"2", "I'll hack the Gibson."},
            {"3", "Zero Cool? Crashed fifteen hundred and seven systems in one day?"},
            {"4", "Turn on your laptop. Set it to receive a file."},
            {"5", "Listen you guys, help yourself to anything in the fridge. Cereal has."}
        };

        NewRelic.Api.Agent.NewRelic.RecordCustomEvent("serkaneren",quotes);
        
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
    }
}