namespace Labor6.Model;

public interface IPizza
{
    List<double> Zutaten { get; }
    double BerechnePreis();
}