using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkAkademi_N060_OOPPornek
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Urun u1 = new Urun()
                {
                    UrunAdi="Ekmek",
                    UrunId=1000,
                    UrunKatagörisi=UrunKaagorileri.Gıda
                };

                Urun u2 = new Urun() 
                {
                    UrunAdi = "Şarj Aleti",
                    UrunId = 1001,
                    UrunKatagörisi = UrunKaagorileri.Elektronik
                };

                Urun u3 = new Urun()
                {
                    UrunAdi = "Süt",
                    UrunId = 1002,
                    UrunKatagörisi = UrunKaagorileri.Gıda
                };

                Urun u4 = new Urun()
                {
                    UrunAdi = "Şampuan",
                    UrunId = 1003,
                    UrunKatagörisi = UrunKaagorileri.Temizlik
                };

                Musteri m = new Musteri()
                {
                    MusteriId=1,
                    Cinsiyeti=Cinsiyetler.Erkek,
                    DogumTarihi=new DateTime(1978,11,29) ,
                    MusteriAdi="Faik",
                    MusteriSoyadi="Turhan"
                };

                UrunSepeti musterininSepeti = new UrunSepeti() 
                { 
                    MusteriId=m.MusteriId,
                    sepetId=1
                };

                musterininSepeti.UrunlerListesi.Add(u1);
                musterininSepeti.UrunlerListesi.Add(u2);
                musterininSepeti.UrunlerListesi.Add(u3);
                musterininSepeti.UrunlerListesi.Add(u4);

                m.MusterininUrunSepeti = musterininSepeti;//Önce sepeti ve sepete eklenecek urunleri
                                                          //yukarıda ekledik sonra o sepeti musterime atatım.
                m.MusteriBilgileriYazdır();
                m.MusterininSepetiniYazdır();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());
            }

            Console.ReadKey();
        }
    }
}
