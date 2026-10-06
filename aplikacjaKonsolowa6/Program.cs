
using static System.Net.Mime.MediaTypeNames;

class Program
{
    static int[] tab = new int[10];
    static void Main(string[] args)
    {
        notatka n1 = new notatka();
        notatka n2 = new notatka();
        n1.Wyswietl();
        n1.diagnostyka();
        n2.diagnostyka();
    }

     class notatka
    {
        private static int licznik = 0;
        private int id;
        protected string tytul;
        protected string tresc;
        public  notatka()
        {
            licznik++;
            id= licznik;
            Console.WriteLine("Podaj tytul notatki");
            tytul = Console.ReadLine();
            Console.WriteLine("Podaj tresc notatki");
            tresc = Console.ReadLine();
            
        }

        public void Wyswietl()
        {
            Console.WriteLine("Tytul: " + tytul);
            Console.WriteLine("Tresc: " + tresc);
        }
        public void diagnostyka()
        {
            Console.WriteLine(licznik + "," + id + "," + tytul + "," + tresc);
        }

    }
}