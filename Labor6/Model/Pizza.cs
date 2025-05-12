namespace Labor6.Model;

public class Pizza : IPizza
{
    public List<double> Zutaten { get; }

    public Pizza(List<double> zutaten)
    {
        Zutaten = zutaten;
    }

    public double BerechnePreis()
    {
        var preis = 8.0; //Grundpreis

        for (var i = 0; i < Zutaten.Count; i++)
        {
            preis += Zutaten[i]; //Preis der Zutaten
        }
        return preis;
    }
}