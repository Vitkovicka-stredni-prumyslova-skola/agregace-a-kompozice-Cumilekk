namespace AgregaceAKompozice
{
    public class TridniKniha
{
    private readonly Dictionary<Student, List<ZaznamDochazky>> _dochazka;

    public TridniKniha()
    {
        TridniKniha = new TridniKniha();
        _dochazka = new Dictionary<Student, List<ZaznamDochazky>>();
    }

    public void ZapisDochazku(Student s, DateOnly datum, bool pritomen)
    {
        // TODO:
        // pokud student není v dictionary, vytvoř list
        // pak přidej nový ZaznamDochazky
    }

    public void VypisDochazku(Student s)
    {
        // TODO:
        // pokud student nemá záznamy, vypiš "Žádné záznamy"
        // jinak projdi list a vypiš
    }
}
}