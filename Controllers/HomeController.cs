using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EncuestaDojoConModelo.Models;

namespace EncuestaDojoConModelo.Controllers;


public class HomeController : Controller{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger){
        _logger = logger;
    }

    [HttpGet("")]
    public IActionResult Index(){
        return View("Index");
    }

    [HttpPost("survey")]
    public IActionResult Submission(Survey survey){
        Survey newSuvey = survey;
       return View("Result", newSuvey);
    }



    public IActionResult Privacy(){
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error(){
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
