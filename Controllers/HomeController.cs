using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP4.Models;

namespace TP4.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewBag.Nombre = "Valen :)";
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult SelectIndumentaria()
    {
        ViewBag.ListaMedias = Equipos.ListaMedias;
        ViewBag.ListaPantalones = Equipos.ListaPantalones;
        ViewBag.ListaRemeras = Equipos.ListaRemeras;
        ViewBag.Equipos = Equipos.ListaEquipos;
        return View();
    }

    public IActionResult GuardarIndumentaria(int equipo, int media, int pantalon, int remera)
    {
        ViewBag.Worked = 0;
        Indumentaria obj = new Indumentaria(Equipos.ListaMedias[media], Equipos.ListaPantalones[pantalon], Equipos.ListaRemeras[remera]);
        if(Equipos.IngresarIndumentaria(Equipos.ListaEquipos[equipo],  obj)){
            ViewBag.Worked = 1;
        }
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
         
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
