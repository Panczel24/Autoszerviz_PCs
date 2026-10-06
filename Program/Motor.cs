using Program;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class Motor : Jarmu
    {
        private int vegsebesseg;

        public int Vegsebesseg
        {
            get { return vegsebesseg; }
            set
            {
                if (value < 0)
                {
                    vegsebesseg = 0;
                }
                else if (value > 300)
                {
                    vegsebesseg = 300;
                }
                else
                {
                    vegsebesseg = value;
                }
            }
        }

        public Motor(string rendszam, int kor, int kilometerOra, int uzemanyagSzint)
            : base(rendszam, kor, kilometerOra, uzemanyagSzint)
        {
            Vegsebesseg = 300;
        }

        public override void InformaciotAd()
        {
            Console.WriteLine($"{Rendszam} - {Kor} éves motor, {KilometerOra} km-rel, " +
                          $"végsemessége: {Vegsebesseg} km/h");

        }



        public override void Szervizel(int dij)
        {
            base.Szervizel(dij);
            Vegsebesseg -= 10;
            Console.WriteLine($"A motor végsebessége csökkent: {Vegsebesseg} km/h, mivel már nem olyan jó, mint régen, és szervízbe kelett vi nni");
        }
    }
}