﻿using System.Diagnostics;
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
        ViewBag.EquiposIndumentaria = Equipos.EquiposIndumentaria;
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
        int[] parametros = {equipo,media,pantalon,remera};
        List<Indumentaria> ropa = new List<Indumentaria>();
        int temp = 0;
        foreach(int param in parametros){
            temp += (param > -1) ? 1 : 0; 
        }
        if(temp < 4){
            return SelectIndumentaria();
        }else{
            string socks = Equipos.ListaMedias[media];
            string pant = Equipos.ListaPantalones[pantalon];
            string shirt = Equipos.ListaRemeras[remera];
            string team = Equipos.ListaEquipos[equipo];
            ropa.Add(new Indumentaria(socks, pant, shirt));
            if(Equipos.IngresarIndumentaria(team)){
                Equipos.EquiposIndumentaria.Add(team, ropa[ropa.Count - 1]);
            }
        }

        return View();
    }

    public IActionResult Medias()
    {
        string[] medias = new string[10];
        for(int i =1; i <= medias.Length; i++){
            medias[i-1] = $"medias{i}.jpg";
        }
        ViewBag.Medias = medias;
        ViewBag.NameMedia = Equipos.ListaMedias;
        return View();
    }

    public IActionResult Pantalones()
    {
        string[] pants = new string[10];
        for(int i =1; i <= pants.Length; i++){
            pants[i-1] = $"pantalon{i}.webp";
        }
        ViewBag.Pants = pants;
        return View();
    }

    public IActionResult Camisetas()
    {
        ViewBag.Equipos = Equipos.ListaEquipos;
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
         
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
