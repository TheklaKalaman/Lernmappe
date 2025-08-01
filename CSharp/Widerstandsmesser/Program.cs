using Widerstaende;

Widerstand neuerWiderstand = new(Ring.Rot, Ring.Blau, Ring.Braun, Ring.Rot);
Console.WriteLine(neuerWiderstand.BerechneWiderstandOhneToleranz());
Console.WriteLine(neuerWiderstand.Toleranz());
Console.WriteLine(neuerWiderstand.Minimum());
Console.WriteLine(neuerWiderstand.Maximum());