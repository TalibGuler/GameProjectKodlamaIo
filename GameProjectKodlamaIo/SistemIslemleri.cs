using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectKodlamaIo
{
    class SistemIslemleri : IIslemler
    {
        
        public void Add()
        {
            Console.WriteLine("Sisteme oyuncu eklendi.");
        }

        public void Delete()
        {
            Console.WriteLine("Sistemden oyuncu silindi.");
        }

        public void Update()
        {
            Console.WriteLine("Sistemden oyuncu güncellendi.");
        }
  

    }
}
