namespace AgregaceAKompozice
{
    public class ZaznamDochazky
{
    public DateOnly Datum { get; }
    public bool JePritomen { get; }

    public ZaznamDochazky(DateOnly datum, bool jePritomen)
    {
       Datum = datum;
       JePritomen = JePritomen; // TODO
    }

    public override string ToString()
    {
        return $"{Datum}: {(JePritomen ? "Přítomen" : "Nepřítomen")}";
    }
}
}