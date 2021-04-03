using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectKodlamaIo
{
    class GameSell : Game
    {
        public void OyunAl(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName+gamer.Name+" oyununu aldı.");
        }
    }
}
