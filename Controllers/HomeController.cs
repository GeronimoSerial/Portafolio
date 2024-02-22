using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;
using Portafolio.Services;

namespace Portafolio.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IRepositorioProyectos repositorioProyectos;

    public HomeController(ILogger<HomeController> logger, 
    IRepositorioProyectos repositorioProyectos)
    {
        _logger = logger;
        this.repositorioProyectos = repositorioProyectos;
 
    }

    public IActionResult Index()
    {
        _logger.LogWarning("Este es un mensaje de Warning");
        _logger.LogError("Este es un mensaje de error");
        _logger.LogCritical("Este es un mensaje de critical");
        _logger.LogInformation("Este es un mensaje de log");
        var proyectos = repositorioProyectos.ObtenerProyectos().Take(3).ToList();

        var modelo = new HomeIndexViewModel() { 
            Proyectos = proyectos };
        /*var persona = new Persona()
        {
            Nombre = "Geronimo Serial",
            Edad = 23
        };*/
        
        return View(modelo);
        
    }

    
    public IActionResult Proyectos()
    {
        var proyectos = repositorioProyectos.ObtenerProyectos();

        return View(proyectos);
    }

    [HttpGet]
    public IActionResult Contacto()
    {
         return View();
    }

    [HttpPost]
    public IActionResult Contacto(ContactoViewModel contactoViewModel)
    {
        return RedirectToAction("Gracias");
    }

    public IActionResult Gracias()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

public class repositorioProyectos
{
    internal static object ObtenerProyectos()
    {
        throw new NotImplementedException();
    }
}