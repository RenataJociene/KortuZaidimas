using System;
using System.Linq;

namespace _NamuDarbai
{
    class Program
    {
        static void Main(string[] args)
        {
            KortuKalade kortuKalade = new KortuKalade();
            // Console.WriteLine(kortuKalade.PilnaKalade);

            Console.WriteLine("kiek zaideju 2 ar 4?");
            int zaidejukiekis = Convert.ToInt32(Console.ReadLine());

            if (zaidejukiekis == 2)
            {
                int dalinimas = kortuKalade.PilnaKalade.Length / 2;
                string[] pirmasZaidejas = kortuKalade.PilnaKalade.Take(dalinimas).ToArray();
                string[] antrasZaidejas = kortuKalade.PilnaKalade.Skip(dalinimas).ToArray();
            }

            if (zaidejukiekis == 4)
            {
                int dalinimas = kortuKalade.PilnaKalade.Length / 4;
                string[] pirmasZaidejas = kortuKalade.PilnaKalade.Take(dalinimas).ToArray();
                string[] antrasZaidejas = kortuKalade.PilnaKalade.Skip(dalinimas).Take(dalinimas).ToArray();
                string[] treciasZaidejas = kortuKalade.PilnaKalade.Skip(dalinimas * 2).Take(dalinimas).ToArray();
                string[] ketvirtasZaidejas = kortuKalade.PilnaKalade.Skip(dalinimas * 3).ToArray();
            }

            Console.ReadLine();
        }
    }
}
