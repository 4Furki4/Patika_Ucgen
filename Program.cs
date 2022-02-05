using System;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Konsol_Islemcisi Konsol= new Konsol_Islemcisi();
            Ucgen ucgen= new Ucgen();
            Konsol.GirdiMesajı();
            int uzunluk = Konsol.UcgenUzunluguAlma();
            ucgen.UcgenCiz(uzunluk);
        }
    }
}
