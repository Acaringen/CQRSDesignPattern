﻿namespace DesignPattern.CQRS.DAL
{
    public class Kullanici
    {
        public int Id { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public string Rol { get; set; } // İsteğe bağlı olarak rol bazlı auth için kullanılabilir
    }
}
