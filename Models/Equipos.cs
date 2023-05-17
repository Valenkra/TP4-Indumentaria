static class Equipos {
    public static List<string> ListaEquipos { get; private set; } = new List<string>()
    {"River Plate", "Boca Juniors", "San Lorenzo",
    "Talleres", "Racing", "Independiente", "Belgrano",
    "Lanus", "Rosario Central", "Estudiantes de La Plata"};
    
    public static List<string> ListaMedias { get; private set; } = new List<string>()
    {};
    
    public static List<string> ListaPantalones { get; private set; } = new List<string>()
    {};

    public static List<string> ListaRemeras { get; private set; } = new List<string>()
    {};

    public static Dictionary<string, Indumentaria> EquiposIndumentaria { get; private set; }  

}