using Labor6.Model;

namespace Labor6.Factory;

public class PizzaFactory : IPizzaFactory
{
    public IPizza ErstellePizza(List<double> zutaten)
    {
        return new Pizza(zutaten);
    }
}