using System.Numerics;

public class MoneyMoney
{
    public BigInteger Vorkomma { get; set; }
    public int Nachkomma { get; set; }

    public MoneyMoney(decimal betrag)
    {
        decimal gerundet = Decimal.Round(betrag, 2, MidpointRounding.AwayFromZero);
        Vorkomma = (BigInteger)gerundet;
        Nachkomma = (int)(Math.Abs(gerundet) * 100 % 100);
    }

    public MoneyMoney Summe(MoneyMoney other)
    {
        BigInteger vorkommaSumme = this.Vorkomma + other.Vorkomma;
        int nachkommaSumme = this.Nachkomma + other.Nachkomma;

        if (Nachkomma >= 100)
        {
            Vorkomma += Nachkomma / 100;
            Nachkomma = Nachkomma % 100;
        }

        decimal gesamt = (decimal)vorkommaSumme + nachkommaSumme / 100m;
        return new MoneyMoney(gesamt);
    }

    public MoneyMoney Differenz(MoneyMoney other)
    {
        BigInteger vorkommaDifferenz = this.Vorkomma - other.Vorkomma;
        int nachkommaDifferenz = this.Nachkomma - other.Nachkomma;

        if (nachkommaDifferenz < 0)
        {
            vorkommaDifferenz--;
            nachkommaDifferenz += 100;
        }

        decimal gesamt = (decimal)vorkommaDifferenz + nachkommaDifferenz / 100m;

        if (gesamt < 0)
        {
            return new MoneyMoney(0);
        }

        return new MoneyMoney(gesamt);
    }

    public static MoneyMoney Parse(string input)
    {
        if (decimal.TryParse(input, out decimal betrag))
        {
            return new MoneyMoney(betrag);
        }
        else
        {
            throw new FormatException("Ungültiges Format für Geldbetrag.");
        }
    }

    public override string ToString()
    {
        return $"{Vorkomma}.{Nachkomma:00}";
    }
}