using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectKodlamaIo
{
    class KampanyaIslemleri : IIslemler
    {
        public void Add()
        {
            Console.WriteLine("Sisteme kampanya eklendi.");
        }

        public void Delete()
        {
            Console.WriteLine("Sistemden kampanya silindi.");
        }

        public void Update()
        {
            Console.WriteLine("Sistemden kampanya güncellendi.");
        }
    }
}
