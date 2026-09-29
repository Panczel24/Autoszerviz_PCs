using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    public class Jarmu
    {
       
            private string rendszam;
            private int kor;
            private int kilometerOra;
            private int uzemanyagSzint;
            public bool szervizSzukseges;

            public string Rendszam
            {
                get { return rendszam; }
                set
                {
                    if (string.IsNullOrEmpty(value))
                    {
                        rendszam = "ISMERETLEN";
                    }
                    else
                    {
                        rendszam = value;
                    }
                }
            }

            public int Kor
            {
                get { return kor; }
                set
                {
                    if (value < 0)
                    {
                        kor = 0;
                    }
                    else if (value > 50)
                    {
                        kor = 50;
                    }
                    else
                    {
                        kor = value;
                    }
                }
            }

            public int KilometerOra
            {
                get { return kilometerOra; }
                set
                {
                    if (value < 0)
                    {
                        kilometerOra = 0;
                    }
                    else
                    {
                        kilometerOra = value;
                    }
                }
            }

            public int UzemanyagSzint
            {
                get { return uzemanyagSzint; }
                set
                {
                    if (value < 0)
                    {
                        uzemanyagSzint = 0;
                    }
                    else if (value > 100)
                    {
                        uzemanyagSzint = 100;
                    }
                    else
                    {
                        uzemanyagSzint = value;
                    }
                }
            }

            public bool SzervizSzukseges
            {
                get
                {
                    return KilometerOra >= 200000;
                }
            }

            public Jarmu(string rendszam, int kor, int kilometerOra, int uzemanyagSzint)
            {
                Rendszam = rendszam;
                Kor = kor;
                KilometerOra = kilometerOra;
                UzemanyagSzint = uzemanyagSzint;
            }

            public virtual void InformaciotAd()
            {
                Console.WriteLine($"{Rendszam} - {Kor} éves jármű, {KilometerOra} km-rel.");
            }

            public virtual void Szervizel(int dij)
            {
                if (dij > 100000)
                {
                    KilometerOra -= 10000;
                }

                UzemanyagSzint -= 10;

                Console.WriteLine("A jármű szervizelése megtörtént.");
            }
        }
    }


