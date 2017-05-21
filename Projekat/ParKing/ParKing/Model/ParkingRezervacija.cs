﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParKing.Model
{
    class ParkingRezervacija : Parking
    {
        private Izvjestaj izvjestaj;
        private int brojZauzetihMjesta;
        private int brojMjestaZaRezervaciju;
        private int brojZauzetihMjestaZaRezervaciju;
       // private String telefon;

        public ParkingRezervacija(string adresa, int kapacitet, List<Ocjena> ocjene, int cijena, Izvjestaj izvjestajP,
            String brojTelefona, int brojZauzetihMjesta, int brojMjestaZR, int brojZauzetihMjestaZR) : base(adresa, kapacitet, ocjene, cijena)
        {
            this.izvjestajP = izvjestajP;
            this.brojTelefona = brojTelefona;
            this.brojZauzetihMjesta = brojZauzetihMjesta;
            this.brojMjestaZR = brojMjestaZR;
            this.brojZauzetihMjestaZR = brojZauzetihMjestaZR;
        }

        public Izvjestaj IzvjestajP { get { return izvjestajP; } set { Set(ref izvjestajP, value); } }
        public String BrojTelefona { get { return brojTelefona; } set { Set(ref brojTelefona, value); } }
        public int BrojZauzetihMjesta { get { return brojZauzetihMjesta; } set { Set(ref brojZauzetihMjesta, value); } }
        public int BrojMjestaZR { get { return brojMjestaZR; } set { Set(ref brojMjestaZR, value); } }
        public int BrojZauzetihMjestaZR { get { return brojZauzetihMjestaZR; } set { Set(ref brojZauzetihMjestaZR, value); } }
    }
}
            }
        }
        public int BrojZauzetihMjestaZaRezervaciju
        {
            get { return brojZauzetihMjestaZaRezervaciju; }
            set
            {
                Set(ref brojZauzetihMjestaZaRezervaciju, value);
            }
        }
        public Izvjestaj Izvjestaj
        {
            get { return izvjestaj; }
            set
            {
                Set(ref izvjestaj, value);
            }
        }

    }
}
