Quadrat quadrat = new Quadrat(6);
var A = quadrat.Flaecheninhalt;
Console.WriteLine(A);

var quadrat2 = new Quadrat(3);
var Dreieck = new Dreieck(4, 5, 2, 4);
var Rechteck = new Rechteck(3, 2);

Console.WriteLine(quadrat2.Flaecheninhalt);
Console.WriteLine(Dreieck.Flaecheninhalt);
Console.WriteLine(Rechteck.Flaecheninhalt);

var f = new KomplexeFigur();
f.Hinzufuegen(new Quadrat(3));
f.Hinzufuegen(new Dreieck(4, 5, 2, 4));
f.Hinzufuegen(new Rechteck(3, 2));

Console.WriteLine(f.Flaecheninhalt);