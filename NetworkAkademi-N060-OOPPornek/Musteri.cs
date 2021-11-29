using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkAkademi_N060_OOPPornek
{
    class Musteri
    {
        #region Properties
        public int MusteriId { get; set; }
        public string MusteriAdi { get; set; }
        public string MusteriSoyadi { get; set; }
        public DateTime DogumTarihi { get; set; }
        public Cinsiyetler Cinsiyeti { get; set; }
        public UrunSepeti MusterininUrunSepeti { get; set; }

        #endregion

        #region Metotlar

        public bool MusterininDogumGunumu()
        {
            bool kontrol = false;

            kontrol = (DogumTarihi.Day == DateTime.Now.Day && DogumTarihi.Month == DateTime.Now.Month) ? true : false;

            return kontrol;
        }

        public void MusteriBilgileriYazdır()
        {
            Console.WriteLine($" Müsteri no: {MusteriId}-{MusteriAdi}-{MusteriSoyadi}");
        }

        public void MusterininSepetiniYazdır()
        {
            //Listeyi yazdırmadan once dogum gunu durumuna bakmamız gerekiyor hediye icin.
            if (MusterininUrunSepeti.UrunlerListesi.Count>0)
            {
                if (MusterininDogumGunumu()==true)
                {
                    MusterininUrunSepeti.DogumGunuHediyesiEkle();
                    Console.WriteLine("Dogum gununuz kutlu olsun. Gofret hediyeniz sepete eklendi.");
                }
            }
            int sayac = 1;
            foreach (var item in MusterininUrunSepeti.UrunlerListesi)
            {
                Console.WriteLine(sayac+ " . ürünümüz: "+item.UrunAdi);
                sayac++;
            }
        }

        #endregion


    }
}
