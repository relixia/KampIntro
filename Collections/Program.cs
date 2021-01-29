using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] {"Engin", "Buğra", "Dila" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);

            //isimler = new string[5];
            //isimler[4] = "İlker";
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]);
                //en son yazdığın Console.WriteLine(isimler[0]); kodu çalışacak ama bir şey yazılmayacak konsola.
                //sebebi ise isimler döngüsünü içinde 6 veri barındıran yeni bir string yaptın fakat bu stringde sadece 5. elemanı tanımladın, kalan elemanlar boş.


            List<string> isimler2 = new List<string> {"Engin", "Buğra", "Dila" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[3]);
            Console.WriteLine(isimler2[0]);

        }
    }
}
