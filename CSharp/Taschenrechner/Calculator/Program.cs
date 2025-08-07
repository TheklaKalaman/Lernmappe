var Ausdruck = new Addition(new Negation(new Zahl(5)), new Zahl(3));
Console.WriteLine(Ausdruck.Auswerten()); // Ausgabe: -2