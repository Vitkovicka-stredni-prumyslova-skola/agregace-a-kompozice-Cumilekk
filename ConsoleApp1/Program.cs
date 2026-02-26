namespace AgregaceAKompozice
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var kniha = new TridniKniha();
            var s1 = new Student("Jan", "Novák", 1);
            var s2 = new Student("Eva", "Nová", 2);

            // T01 - první zápis docházky
            Console.WriteLine("T01 - Prvni zaznam dochazky:");
            kniha.ZapisDochazku(s1, new DateOnly(2026, 2, 19), true);
            kniha.VypisDochazku(s1);

            // T02 - student nepřítomen
            Console.WriteLine("\nT02 - Zaznam jako nepritomen:");
            kniha.ZapisDochazku(s1, new DateOnly(2026, 2, 20), false);
            kniha.VypisDochazku(s1);

            // T03 - zápis pro dalšího studenta
            Console.WriteLine("\nT03 - Druhy student:");
            kniha.ZapisDochazku(s2, new DateOnly(2026, 2, 19), true);
            kniha.VypisDochazku(s2);

            // T04 - více dní u jednoho studenta
            Console.WriteLine("\nT04 - Vice zaznamu jednoho studenta:");
            kniha.ZapisDochazku(s1, new DateOnly(2026, 2, 21), true);
            kniha.VypisDochazku(s1);

            // test 5
            Console.WriteLine("\nT05 - Kombinace pritomen/nepritomen:");
            kniha.ZapisDochazku(s2, new DateOnly(2026, 2, 20), false);
            kniha.ZapisDochazku(s2, new DateOnly(2026, 2, 21), true);
            kniha.VypisDochazku(s2);

            // test 6
            Console.WriteLine("\nT06 - Datum na zacatku a konci roku:");
            var s3 = new Student("Petr", "Malý", 1);
            kniha.ZapisDochazku(s3, new DateOnly(2026, 1, 1), true);
            kniha.ZapisDochazku(s3, new DateOnly(2026, 12, 31), false);
            kniha.VypisDochazku(s3);

            // test 7
            Console.WriteLine("\nT07 - Student bez dochazky:");
            var novyStudent = new Student("Novy", "Student", 1);
            kniha.VypisDochazku(novyStudent);

            // test 8
            Console.WriteLine("\nT08 - Null pri zapisu:");
            try
            {
                kniha.ZapisDochazku(null!, new DateOnly(2026, 2, 19), true);
                Console.WriteLine("Bez chyby (NEOCEKAVANE)");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Zachycena vyjimka: " + ex.GetType().Name);
            }



            // test 9 
            Console.WriteLine("\nT09 - Null pri vypisu:");
            try
            {
                kniha.VypisDochazku(null!);
                Console.WriteLine("Bez chyby (NEOCEKAVANE)");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Zachycena vyjimka: " + ex.GetType().Name);
            }



            // test 10
            Console.WriteLine("\nT10 - Dvojity zapis stejneho data:");
            var s4 = new Student("Test", "Duplicita", 1);
            kniha.ZapisDochazku(s4, new DateOnly(2026, 2, 19), true);
            kniha.ZapisDochazku(s4, new DateOnly(2026, 2, 19), false);
            kniha.VypisDochazku(s4);
        }
    }
}