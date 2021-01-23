using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "yazılım gelistirici yetistirme kursu";
            string kurs2 = "programlamaya giris";
            string kurs3 = "java";

            // array - dizi

            string[] kurslar = new string[] { "yazılım gelistirme", 
                "programlamaya giris", "java", "Python", "C#" };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            
            Console.WriteLine("for bitti");

            // kursları dolaş foreach dizilere uygulanır...
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }



            Console.WriteLine("sayfa sonu - footer");
        }
    }
}
