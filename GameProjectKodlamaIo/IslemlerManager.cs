using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectKodlamaIo
{
    class IslemlerManager
    {
        public void Add(IIslemler islemler)
        {
            islemler.Add();
        }
        public void Delete(IIslemler islemler)
        {
            islemler.Delete();
        }
        public void Update(IIslemler islemler)
        {
            islemler.Update();
        }
    }
}
