using Labor6.Factory;
using Labor6.Model;

namespace Labor6;

public class BestellungMitFactory
{

    public List<IPizza> Pizzas { get; }
    private readonly IPizzaFactory _factory;

    public BestellungMitFactory(IPizzaFactory factory)
    {
        _factory = factory;
        Pizzas = new List<IPizza>();
    }

    public void BestellePizza(List<double> zutaten)
    {
        Pizzas.Add(_factory.ErstellePizza(zutaten));
    }

    public double BerechnePreis()
    {
        var preis = 0.0;

        //Hier wurde ein Fehler gemacht
        for (var i = 1; i < Pizzas.Count; i++)
        {
            preis += Pizzas[i].BerechnePreis();
        }

        return preis;
    }

}