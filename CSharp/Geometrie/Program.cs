Quadrat quadrat = new Quadrat(6);
var A = quadrat.Flaecheninhalt;
Console.WriteLine(A);

var quadrat2 = new Quadrat(3);
var Dreieck = new Dreieck(4, 5, 2, 4);
var Rechteck = new Rechteck(3, 2);
var Kreis = new Kreis(2);
var Kreisausschnitt = new Kreisausschnitt(8, 170);

Console.WriteLine(quadrat2.Flaecheninhalt);
Console.WriteLine(Dreieck.Flaecheninhalt);
Console.WriteLine(Rechteck.Flaecheninhalt);
Console.WriteLine(Kreis.Flaecheninhalt);
Console.WriteLine(Kreisausschnitt.Flaecheninhalt);

Console.WriteLine(quadrat2.Flaecheninhalt
        + Dreieck.Flaecheninhalt
        + Rechteck.Flaecheninhalt
        + Kreis.Flaecheninhalt
        + Kreisausschnitt.Flaecheninhalt);

var f = new KomplexeFigur();
f.Hinzufuegen(new Quadrat(3));
f.Hinzufuegen(new Dreieck(4, 5, 2, 4));
f.Hinzufuegen(new Rechteck(3, 2));
f.Hinzufuegen(new Kreis(2));
f.Hinzufuegen(new Kreisausschnitt(8, 170));

Console.WriteLine(f.Flaecheninhalt);