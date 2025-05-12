using System.Collections.Generic;
using FluentAssertions;
using Labor6.Factory;
using Labor6.Model;
using NSubstitute;
using NUnit.Framework;

namespace Labor6.Tests;

[TestFixture]
[TestOf(typeof(Bestellung))]
public class BestellungTest
{

    [Test]
    public void NoFactory_ShouldFail()
    {
        var bestellung = new Bestellung();
        bestellung.BestellePizza([1.0,1.0]); // 8€ + 2€
        bestellung.BestellePizza([1.0,1.0]); // 8€ + 2€

        //Bestellung Gesamtwert sollte 20€ sein
        bestellung.BerechnePreis().Should().Be(20.0);
        
        //Ist es aber nicht -> Wo ist der Fehler?
        //Könnte entweder in Pizza oder Bestellung sein
    }

    [Test]
    public void FactoryToTheRescue()
    {
        IPizza fakePizza = Substitute.For<IPizza>();
        fakePizza.BerechnePreis().Returns(10.0); // fakePizzas kosten alle 10€
        
        IPizzaFactory fakeFactory = Substitute.For<IPizzaFactory>();
        fakeFactory.ErstellePizza(Arg.Any<List<double>>()).Returns(fakePizza); // egal welcher Eingabewert, Ausgabe ist immer fakePizza
        
        var bestellung = new BestellungMitFactory(fakeFactory);
        bestellung.BestellePizza([1.0,1.0]);
        bestellung.BestellePizza([1.0,1.0]);
        // Der genaue Preis ist hier egal, da wir nur die Logik von der Klasse Bestellung testen
        
        bestellung.BerechnePreis().Should().Be(20.0);
        //schlägt auch fehl -> Der Fehler MUSS in BerechnePreis() sein
    }
}