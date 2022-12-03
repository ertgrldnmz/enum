internal class Program
{
    private static void Main(string[] args)
    {
        int sıcaklık=32;

        if(sıcaklık<(int)HavaDurumu.Normal)
        {
            Console.WriteLine("Dışarı çıkmak için sıcak bir gün değil");
        }
        else if(sıcaklık>(int)HavaDurumu.Coksıcak)
        {
             Console.WriteLine("Dışarı çıkmak için çok sıcak bir gün");


        }
        else if(sıcaklık<(int)HavaDurumu.Soguk)
        {
             Console.WriteLine("Dışarı çıkmak için çok soğuk bir gün ");

        }
        else
        {
             Console.WriteLine("Hadi Dışarı Çıkalım");

        }
      
    }
    enum Gunler
    {
        Pazartesi,

        Salı,

        Çarşamba,

        Perşembe,

        Cuma,

        Cumartesi,

        Pazar,



    }
    enum HavaDurumu
    {
        Soguk=5,
        Normal=20,

        Sıcak=25,

        Coksıcak=30

    }
}