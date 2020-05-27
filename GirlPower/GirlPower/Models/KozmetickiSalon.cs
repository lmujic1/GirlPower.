using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GirlPower.Models
{
    public class KozmetickiSalon : IKreatorIteratora, Registracija, Prijava, HitanSlucaj, PosaljiObavijest,PosaljiPoruku,IPravaPristupa
    {
        private IteratorRezervacija iterator;
        private ICollection<IPrototip> tretmani;
        private ICollection<IKlijentObserver> klijenti;
        private ICollection<Rezervacija> rezervacije;
        private ICollection<Uposlenik> uposlenici;
        private ICollection<Kategorija> kategorije;
        private KozmetickiSalon instanca;

        private KozmetickiSalon() { }

        public ICollection<Uposlenik> Uposlenici { get => uposlenici; set => uposlenici = value; }
        public ICollection<Kategorija> Kategorije { get => kategorije; set => kategorije = value; }

        //interfejs IPravaPristupa
        public void dodajNoviTretman(Tretman tretman)
        {
            throw new NotImplementedException();
        }

        public void dodajNovogUposlenika(Uposlenik uposlenik)
        {
            uposlenici.Add(uposlenik);
            //throw new NotImplementedException();
        }

        public void dodajNovuKategoriju(Kategorija kategorija)
        {
            kategorije.Add(kategorija);
        }

        public void dodajRezervaciju(Rezervacija rezervacija)
        {
            rezervacije.Add(rezervacija);
        }

        public KozmetickiSalon getInstance()
        {
            if(instanca==null) instanca = new KozmetickiSalon();
            return instanca;
        }

       

        public void obrisiKategoriju(Kategorija kategorija)
        {
            kategorije.Remove(kategorija);
        }

        public void obrisiKlijenta(Klijent klijent)
        {
            throw new NotImplementedException();
        }

        public void obrisiRezervaciju(Rezervacija rezervacija)
        {
            rezervacije.Remove(rezervacija);
        }

        public void obrisiTretman(Tretman tretman)
        {
            throw new NotImplementedException();
        }

        public void obrisiUposlenika(Uposlenik uposlenik)
        {
            uposlenici.Remove(uposlenik);
        }

        public void promijeniRezervaciju(Rezervacija rezervacija)
        {
            throw new NotImplementedException();
        }

        public void urediTretman(Tretman tretman)
        {
            throw new NotImplementedException();
        }

        //interfejs IKreirajIterator
        public void kreirajIterator(int vrsta, ICollection<Rezervacija> rezervacije)
        {
            if (vrsta == 0) {
                iterator = new DatumVrijemeIterator(rezervacije);
            } else if(vrsta == 1)
            {
                iterator = new UposlenikIterator(rezervacije);
            }
            //throw new NotImplementedException();
        }
    }
}
