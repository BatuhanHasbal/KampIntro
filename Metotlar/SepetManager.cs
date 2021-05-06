using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention 
        //normal parantez varsa metod calısıyor demektir.
        public void Ekle(Urun urun)  // 1. tip  2. çağırmak için isimlendirme
        {
            Console.WriteLine("Sepete eklendi : " + urun.Adi  + "Stok : " + urun.StokDurumu);
        }

        public void Ekle2()
        {

        }
    }
}
