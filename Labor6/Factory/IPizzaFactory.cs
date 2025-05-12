using Labor6.Model;

namespace Labor6.Factory;

public interface IPizzaFactory
{
    IPizza ErstellePizza(List<double> zutaten);
}