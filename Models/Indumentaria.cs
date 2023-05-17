class Indumentaria {
    public string medias { get; set; }
    public string pantalon { get; set; }
    public string camiseta { get; set; }

    public Indumentaria()
    {
        medias = "";
        pantalon = "";
        camiseta = "";
    }

    public Indumentaria(string media, string pant, string shirt)
    {
        medias = media;
        pantalon = pant;
        camiseta = shirt;
    }
}