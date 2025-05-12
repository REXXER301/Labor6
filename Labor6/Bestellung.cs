using Labor6.Factory;
using Labor6.Model;

namespace Labor6;

public class Bestellung
{
    public List<Pizza> Pizzas { get; }
    
    public Bestellung(List<Pizza> pizzas)
    {
        Pizzas = pizzas;
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