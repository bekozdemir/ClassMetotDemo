using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Name +" "+ musteri.LastName + " eklendi.");
            Console.WriteLine();
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.Name + " " + musteri.LastName + " silindi.");
            Console.WriteLine();
        }

        public void Listele(Musteri[] musteri)
        {

            for (int i = 0; i < musteri.Length; i++)
            {
                Console.WriteLine(musteri[i].Name +" "+ musteri[i].LastName +" - "+ musteri[i].Id + " : " + musteri[i].CurrentBallance);
                Console.WriteLine();
            }
          
        }
    }
}
