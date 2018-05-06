using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SecBegenAl
{
    class Urun
    {
        public int cinsiyetKategori;
        public int id;
        public string aciklama;
        public string renk;
        public int beden;
        public int fiyat;
        public string resim_url;
        public int satici_id;
        public string urun_adi;
        public int kategori;


        public Urun() { }


        public Urun(int cinsiyetKategori, int id, string aciklama, string renk, int beden, int fiyat, string resim_url, int satici_id, string urun_adi, int kategori)
        {
            this.cinsiyetKategori = cinsiyetKategori;
            this.id = id;
            this.aciklama = aciklama;
            this.renk = renk;
            this.beden = beden;
            this.fiyat = fiyat;
            this.resim_url = resim_url;
            this.satici_id = satici_id;
            this.urun_adi = urun_adi;
            this.kategori = kategori;
        }



        public string yazdir()
        {
            return urun_adi + " " + aciklama;
        }
    }
}
