using System;

namespace DongulerAsil
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya Başlangıç için Temel Kurs";
            string kurs3 = "Java";
            string kurs4 = "Python";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);

            //üstteki kurs1 kurs2 kurs3 kurs4 olayı amele işi, onu yapma 
            //array = diziler

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", "Programlamaya Başlangıç için Temel Kurs", "Java", "Python", "C#" };

            //i++ = i nin 1 er 1 er artmasını sağlar ve i = i + 1 de aynı işlevi görür.
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For döngüsü bitti.");

            //for döngüsü ve foreach döngüsü arasında bir fark yok, istediğini kullan ama foreach daha kolay gibi. 
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu");
        }
    }
}
