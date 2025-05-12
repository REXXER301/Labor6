# Beschreibung
In diesem Projekt werden die Vorteile des Entwurfsmuster "Fabrik" präsentiert. <br>  

# Aufbau
Nachdem eine Bestellung erstellt wird, können Pizzen hinzugefügt werden. <br>
Mit BerechnePreis kann der Gesamtwert der Bestellung berechnet werden. <br>

## Problem
Bestellung.BerechnePreis gibt einen falschen Wert zurück.

## Lösung
Normalerweise wäre dieser schwer zu finden, da der Preis von Pizza und Bestellung abhängt.    
Mithilfe von Factories kann die Logik der Pizzas substituiert werden und die Logik der Bestellung isoliert getestet werden.
