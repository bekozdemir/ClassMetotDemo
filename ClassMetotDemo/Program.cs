using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Name = "Kerem";
            musteri1.LastName = "Fal";
            musteri1.CurrentBallance = 536.12;
            musteri1.Id = 1111;

            Musteri musteri2 = new Musteri();
            musteri2.Name = "Koray";
            musteri2.LastName = "San";
            musteri2.CurrentBallance = 536.12;
            musteri2.Id = 2222;

            Musteri musteri3 = new Musteri();
            musteri3.Name = "Ahmet";
            musteri3.LastName = "Tartı";
            musteri3.CurrentBallance = 536.12;
            musteri3.Id = 3333;

            Musteri[] musteriler = new Musteri[] {musteri1, musteri2, musteri3};

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Ekle(musteri1);

            musteriManager.Sil(musteri3);

            musteriManager.Listele(musteriler);
        }
    }
}
