using System;
namespace Triangle
{
    public class Ucgen
    {
        public void UcgenCiz(int UcgenUzunlugu)
        {
            for (int i = 1; i <= UcgenUzunlugu; i++)
            {
                for (int j = 0; j < UcgenUzunlugu-i; j++)
                {
                    Console.WriteLine(" ");
                }

                for (int k = 0;  k< 2*i-1; k++)
                {
                    Console.WriteLine("*");
                }
            }
        }
    }
}







/*
    *          1
   ***         3
  *****        5
 *******       7
*********      9
    11

*/