using System;
namespace Triangle
{
    public class Konsol_Islemcisi
    {
        public void GirdiMesajı()
        {
            System.Console.Write("Lütfen üçgenin yüksekliğini giriniz:");
        }
        public int UcgenUzunluguAlma()
        {
            int uzunluk= int.Parse(Console.ReadLine());
            return uzunluk;
        }
    }
}