/* 

Wir bekommen einen Betrag genannt, geben eine Summe und bekommen eine Summe zurück.

Input: Betrag
Input: Bezahlter Betrag
Output: Differenz

1. Methode: Berechnet die Differenz zwischen verlangtem Betrag und gegebenem Betrag.
2. Methode: Nimmt das Ergebnis der 1. Methode und zerlegt es mit der 3. Methode in Scheine und Münzen.
3. Methode: Zerlegt beliebige eingegebene Beträge in Scheine und Münzen.

1. Klasse: Wechselautomat
2. Klasse: Geld

*/

// MoneyMoney m = new MoneyMoney(2.515m);
// MoneyMoney summand1 = new MoneyMoney(2.505m);
// MoneyMoney summand2 = new MoneyMoney(21432434234412.75m);
// MoneyMoney minuend = new MoneyMoney(10240.009042m);
// MoneyMoney subtrahend = new MoneyMoney(50342.0423404m);

// Console.WriteLine(m);
// Console.WriteLine(summand1);
// Console.WriteLine(summand2);

// Console.WriteLine(summand1.Summe(summand2));
// Console.WriteLine(minuend);
// Console.WriteLine(subtrahend);
// Console.WriteLine(minuend.Differenz(subtrahend));

// Bezahlung zahlung = new Bezahlung(new MoneyMoney(2.50m), new MoneyMoney(2.00m));
// Console.WriteLine(zahlung.BerechneDifferenz());

//Main Method einfügen

public class Program
{
    public static void Main(string[] args)
    {
        Wechselautomat wechselautomat = new Wechselautomat();
        wechselautomat.Start();
    }
}