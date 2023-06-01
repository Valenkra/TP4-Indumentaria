static class Equipos {
    public static List<string> ListaEquipos { get; private set; } = new List<string>()
    {"River Plate", "Boca Juniors", "San Lorenzo",
    "Talleres", "Racing", "Independiente", "Belgrano",
    "Lanus", "Rosario Central", "Estudiantes de La Plata"};
    
    public static List<string> ListaMedias { get; private set; } = new List<string>()
    { "Gris Alta", "Dos rayas", "Alta Jordan", 
    "Adidas True Colors", "Adidas - FILA", "Classic Band", 
    "Soquete Nike", "Soquete Puma", "Soquete ROSA", "FUNNY SOCKS",};
    public static List<string> ListaPantalones { get; private set; } = new List<string>()
    { "Azul Argentina","Argentina Classic","Adidas Black",
    "Full Black", "Red Eagle",
    "True Colors","A. Sports","Gris Team",
    "Full Green","Adidas Classic"};

    public static List<string> ListaRemeras { get; private set; } = new List<string>()
    { "Argentina Clasica", "River Negra" , "River Clasica",
    "Boca JRS Amarillo", "Boca Juniors Classic", "River Plate Codere",
    "Arsenal - Adidas", "Argentina Azul-Dorado", "Argentina Azul-Celeste",
    "Deutscher Fussball Bund"};

    public static Dictionary<string, Indumentaria> EquiposIndumentaria { get; private set; }  = new Dictionary<string, Indumentaria>();

    public static bool IngresarIndumentaria(string EquipoSeleccionado, Indumentaria indu){
        if(!EquiposIndumentaria.ContainsKey(EquipoSeleccionado)){
            EquiposIndumentaria.Add(EquipoSeleccionado, indu);
            return true;
        }else{
            return false;
        }
    }

}