using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _NamuDarbai
{
    public class KortuKalade : KortuKaladeMasyvai
    {
        public string[] PilnaKalade;
        public KortuKalade()
        {
            VisosKortos();
            var pilnaKaladeList = new List<string>();
            pilnaKaladeList.AddRange(suformuotaKorta);

            Random r1 = new Random();
            PilnaKalade = pilnaKaladeList.OrderBy(x => r1.Next()).ToArray();
            Console.WriteLine("Pilna ismaisyta kalade: {0}", string.Join(", ", PilnaKalade));       
        }
    }
}
