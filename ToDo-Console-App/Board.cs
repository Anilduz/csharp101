using System;
namespace ToDoApp{
    class Board{
        private string baslik;
        private string icerik;
        private string atananKisi;

        public string Baslik1 { get => baslik; set => baslik = value; }
        public string Icerik1 { get => icerik; set => icerik = value; }
        public string AtananKisi1 { get => atananKisi; set => atananKisi = value; }

        enum Buyukluk{
            XS,
            S,
            M,
            L,
            XL
        }
    }
}