using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecBegenAl
{
    class Urun
    {
        public int cinsiyetKategori;
        /*cinsiyet kategori için  
        Kadın 1 
        Erkek 2
        unisex 3
         * genç kadın 4
         * genç erkek 5
          genç unisex 6
         * çocuk kadın 7
         * çocuk erkek 8
         * çocuk unisex 9
         * bebek kadın 10
         * bebek erkek 11
         * bebek unisex 12 
         */
        public int id;
        public string aciklama;
        public int renk;
        public string beden;
        public int fiyat;
        public int resim_url;
        public int satici_id;
        public string urun_adi;
        public int kategori;
        
        
        public Urun() { }
       
        
        public Urun(int cinsiyetKategori, int id, string aciklama, int renk, string beden, int fiyat, int resim_url, int satici_id, string urun_adi,int kategori)
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



        public string yazdir() {
            return urun_adi +" "+aciklama;
        }



    }
}
