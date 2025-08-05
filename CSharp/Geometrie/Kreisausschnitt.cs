public class Kreisausschnitt : IGeometrie
{
    public Kreis kreis;
    private double winkel;
    public double Flaecheninhalt => SegmentFlaeche(winkel);
    public double Umfang => KreissegmentUmfang(winkel);

    public Kreisausschnitt(double radius, double winkel)
    {
        kreis = new Kreis(radius);
        this.winkel = winkel;
    }

    public double SegmentFlaeche(double winkel) =>
        kreis.Umfang * kreis.Umfang / 2 * Math.PI * winkel / 360;
    
    public double SektorUmfang(double winkel) =>
        kreis.Umfang + Kreisbogen(winkel);

    public double Kreisbogen(double winkel) =>
        kreis.Umfang / 2 * Math.PI * winkel / 180;

    public double Kreissehne(double winkel) =>
        2 * kreis.Umfang / 2 * Math.Sin(winkel / 2);

    public double SegmentHoehe(double winkel) =>
        Kreissehne(winkel) / 2 * Math.Tan(winkel / 4);

    public double SegmentDreieck(double winkel) =>
        winkel <= 180
            ? Kreissehne(winkel) * (kreis.Umfang / 2 - SegmentHoehe(winkel)) 
            : Kreissehne(winkel) * (SegmentHoehe(winkel) - kreis.Umfang / 2);

    public double Kreissegment(double winkel) =>
        winkel <= 180
            ? SegmentFlaeche(winkel) - SegmentDreieck(winkel) 
            : SegmentFlaeche(winkel) + SegmentDreieck(winkel);
    
    public double KreissegmentUmfang(double winkel) =>
        Kreissehne(winkel) + Kreisbogen(winkel); 
}