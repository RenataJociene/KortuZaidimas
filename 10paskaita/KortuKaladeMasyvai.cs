using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _NamuDarbai
{
    public class Korta
    {
        public string KortosPavadinimas { get; set; }
    }
    public class KortuKaladeMasyvai
    {
         public List<string> suformuotaKorta = new List<string>();
        public void VisosKortos()
        {
            var reiksme = new List<string> { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };

            for (int i = 2; i <= 14; i++)
            {
                foreach (var reikme in reiksme)
                {
                    suformuotaKorta.Add(Enum.GetName(typeof(KortosSim.KortosSimboliai), i));
                }
            }
        }
    }
}
