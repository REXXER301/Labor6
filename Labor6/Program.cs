using Labor6;
using Labor6.Model;

var bestellung = new Bestellung([
    new Pizza([1.0,1.0]), // 8€ + 2€
    new Pizza([1.0,1.0])  // 8€ + 2€ 
]);

//Bestellung Gesamtwert sollte 20€ sein