namespace AgregaceAKompozice
{
public class Trida
{
    public string Nazev { get; }
    public List<Student> Studenti { get; } = new ();

    // KOMPOZICE: třídní kniha vzniká spolu s třídou
    public TridniKniha TridniKniha { get; }

    public Trida(string nazev)
    {
        if(string.IsNullOrWhiteSpace(nazev))
                throw new ArgumentException("Nazev třídy nesmí být prázdný nebo obsahovat pouze bílé znaky.", nameof(nazev));
        Nazev = nazev.Trim();

        TridniKniha = new TridniKniha();
    }

    
    public void PridejStudenta(Student s)
    {
      if(s == null) throw new ArgumentException(nameof(s));
      if(Studenti.Contains(s))
        throw new InvalidOperationException("Student již je ve třídě zapsán."); 
       
        Studenti.Add(s);
    }

    public void OdeberStudenta(Student s)
    {
      if(s == null) throw new ArgumentException(nameof(s));
        if(!Studenti.Contains(s))
            throw new InvalidOperationException("Student ve třídě není."); 
         
            Studenti.Remove(s);
    }

    public void VypisStudenty()
    {
     Console.WriteLine($"Třída {Nazev}:");

     if (Studenti.Count == 0)
     {
        Console.WriteLine("žádní studenti");
        return;
     }
     

     for(int i = 0; i < Studenti.Count; i++)
     {
        Console.WriteLine($"{i + 1}. {Studenti[i]}");
     }
    }
}
}