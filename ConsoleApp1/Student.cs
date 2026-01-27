namespace AgregaceAKompozice
{
    public class Student
{
    public string Jmeno { get; }
    public string Prijmeni { get; }
    public int Rocnik { get; }

    public Student(string jmeno, string prijmeni, int rocnik)
    {
        if(string.IsNullOrWhiteSpace(jmeno))
        {
            throw new ArgumentException("Jméno nesmí být prázdné nebo obsahovat pouze bílé znaky.", nameof(jmeno));
        }
        
        if(string.IsNullOrWhiteSpace(jmeno))
        {
            throw new ArgumentException("Jméno nesmí být prázdné nebo obsahovat pouze bílé znaky.", nameof(prijmeni));
        }

        
        if(string.IsNullOrWhiteSpace(jmeno))
        {
            throw new ArgumentException("Jméno nesmí být prázdné nebo obsahovat pouze bílé znaky.", nameof(rocnik));
        }

       Jmeno = jmeno.Trim();
       Prijmeni = prijmeni.Trim();
       Rocnik = rocnik;
    }

    public override string ToString() => $"{Jmeno} {Prijmeni} {Rocnik}. ročník";
}
}