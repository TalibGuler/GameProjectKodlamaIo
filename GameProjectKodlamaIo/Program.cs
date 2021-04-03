using System;

namespace GameProjectKodlamaIo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Gamer gamer1 = new Gamer();
            Gamer gamer2 = new Gamer {Id=2,Name="Engin",LastName="DEMİROĞ",TcNo="22222222222",dateTime="10.05.1990" };
            EDevlet devlet = new EDevlet();
            SistemIslemleri sistem = new SistemIslemleri();
            GameSell gameSell = new GameSell();
            gamer1.Id = 1;
            gamer1.Name = "Abdülmuttalib";
            gamer1.LastName = "GÜLER";
            gamer1.TcNo = "11111111111";
            gamer1.dateTime = "10.05.1990";

            IslemlerManager islemler = new IslemlerManager();
            islemler.Add(sistem);
            gameSell.OyunAl(gamer1);

            //IManager systemManager = new SystemManager();
            //IManager campaignManager = new CampaignManager();
            //systemManager.Add(gamer1);
            //campaignManager.Add(gamer1);
            
        }
    }
}
