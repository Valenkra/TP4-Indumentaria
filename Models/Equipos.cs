static class Equipos {
    public static List<string> ListaEquipos { get; private set; } = new List<string>()
    {"River Plate", "Boca Juniors", "San Lorenzo",
    "Talleres", "Racing", "Independiente", "Belgrano",
    "Lanus", "Rosario Central", "Estudiantes de La Plata"};
    
    public static List<string> ListaMedias { get; private set; } = actualizarLista("medias");
    public static List<string> ListaPantalones { get; private set; } = actualizarLista("camiseta");

    public static List<string> ListaRemeras { get; private set; } = actualizarLista("pantalon");

    public static Dictionary<string, Indumentaria> EquiposIndumentaria { get; private set; }  

    public static bool IngresarIndumentaria(string EquipoSeleccionado, Indumentaria item){
        return EquiposIndumentaria.ContainsKey(EquipoSeleccionado);
    }

    static List<string> actualizarLista(string name){
        List<string> lista = new List<string>();
        for (int i = 1; i <= 10; i++)
        {
            lista.Add($"{name}{i}");
        };
        return lista;
    }

}