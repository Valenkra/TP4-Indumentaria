static class Equipos {
    public static List<string> ListaEquipos { get; private set; } = new List<string>()
    {"River Plate", "Boca Juniors", "San Lorenzo",
    "Talleres", "Racing", "Independiente", "Belgrano",
    "Lanus", "Rosario Central", "Estudiantes de La Plata"};
    
    public static List<string> ListaMedias { get; private set; } = new List<string>()
    { "media cheta", "media 1"};
    public static List<string> ListaPantalones { get; private set; } = new List<string>(){ "media cheta", "media 1"};

    public static List<string> ListaRemeras { get; private set; } = new List<string>()
    { "Argentina Clasica", "River Negra" , "River Clasica",
    "Boca JRS Amarillo", "Boca Juniors Classic", "River Plate Codere",
    "Arsenal - Adidas", "Argentina Azul-Dorado", "Argentina Azul-Celeste",
    "Deutscher Fussball Bund"};

    public static Dictionary<string, Indumentaria> EquiposIndumentaria { get; private set; }  

    public static bool IngresarIndumentaria(string EquipoSeleccionado){
        return EquiposIndumentaria.ContainsKey(EquipoSeleccionado);
    }

}