using System;
using System.Collections.Generic;
using System.Text;

namespace eRestoran.MobileApp.Models
{
    public class NarudzbaStavke
    {
        public int DetaljiNarudzbeId { get; set; }
        public int Kolicina { get; set; }
        public double Cijena { get; set; }
        public int NarudzbaId { get; set; }
        public int JeloId { get; set; }
        public string Jelo { get; set; }
        public string Model { get; set; }
    }
}
