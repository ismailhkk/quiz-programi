namespace quiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] sorular = { "Gökyüzü ne renktir?", "Türkiye'nin başkenti neresidir?", "En büyük gezegen hangisidir?", "Yer yüzeyinin yüzde kaçı su ile kaplıdır?", "İlk insan nerede yaşadı?" };
            string[] cevaplar = { "mavi", "ankara", "jüpiter", "yüzde 71", "afrika" };
            string[] secenekler = { "kırmızı|Mavi|Pembe|Mor", "Ankara|İstanbul|İzmir", "Jüpiter|Satürn|Mars|Dünya", "yüzde 30|yüzde 50|yüzde 71|yüzde 90", "Asya|Afrika|Avrupa|Amerika" };

            int dogruSayisi = 0;
            int yanlisSayisi = 0;

            for (int i = 0; i < sorular.Length; i++)
            {
                Console.Clear();
                Console.WriteLine($"Soru {i + 1}: {sorular[i]}");

                string[] secenekListesi = secenekler[i].Split('|');
                for (int j = 0; j < secenekListesi.Length; j++)
                {
                    Console.WriteLine($"{j + 1}. {secenekListesi[j]}");
                }

                Console.Write("Cevabınızı girin (1-" + secenekListesi.Length + "): ");
                int kullaniciCevabiIndex = Convert.ToInt32(Console.ReadLine()) - 1;
                string kullaniciCevabi = secenekListesi[kullaniciCevabiIndex];

                if (kullaniciCevabi.ToLower() == cevaplar[i])
                {
                    Console.WriteLine("Doğru!");
                    dogruSayisi++;
                }
                else
                {
                    Console.WriteLine("Yanlış! Doğru cevap: " + cevaplar[i]);
                    yanlisSayisi++;
                }
                Console.WriteLine();
            }

            Console.WriteLine($"Toplam doğru sayısı: {dogruSayisi}     Toplam yanlış sayısı: {yanlisSayisi }");
        }
    }
}
