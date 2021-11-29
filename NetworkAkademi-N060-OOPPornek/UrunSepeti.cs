using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkAkademi_N060_OOPPornek
{
    class UrunSepeti
    {
        public int sepetId { get; set; }
        public int MusteriId { get; set; }

        public List<Urun> UrunlerListesi { get; set; } = new List<Urun>();

        public void DogumGunuHediyesiEkle()
        {
            Urun hediye = new Urun()
            {
                UrunAdi = "Gofret",
                UrunId = 300,
                UrunKatagörisi = UrunKaagorileri.Gıda
            };

            UrunlerListesi.Add(hediye);

        }
    }
}
