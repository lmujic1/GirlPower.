using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GirlPower.Models
{
    public class KozmetickiSalon : IKreatorIteratora, Registracija, Prijava, HitanSlucaj, PosaljiObavijest,PosaljiPoruku, IPravaPristupa
    {
         
        IteratorRezervacija iterator;
        ICollection<IPrototip> oTretmani;
        ICollection<Tretman> tretmani;
        ICollection<IKlijentObserver> oKlijenti;
        ICollection<Klijent> klijenti;
        ICollection<Rezervacija> rezervacije;
        ICollection<Uposlenik> uposlenici;
        ICollection<Kategorija> kategorije;
        private static KozmetickiSalon instanca;


        public ICollection<Uposlenik> Uposlenici { get => uposlenici; set => uposlenici = value; }
        public ICollection<Kategorija> Kategorije { get => kategorije; set => kategorije = value; }
      
        public IteratorRezervacija Iterator { get => iterator; set => iterator = value; }
        public ICollection<IPrototip> OTretmani { get => oTretmani; set => oTretmani = value; }
        public ICollection<Tretman> Tretmani { get => tretmani; set => tretmani = value; }
        public ICollection<IKlijentObserver> OKlijenti { get => oKlijenti; set => oKlijenti = value; }
        public ICollection<Klijent> Klijenti { get => klijenti; set => klijenti = value; }
        public ICollection<Rezervacija> Rezervacije { get => rezervacije; set => rezervacije = value; }

        //interfejs IPravaPristupa
        public void dodajNoviTretman(Tretman tretman)
        {
            Tretmani.Add(tretman);
            obavijestiKlijete(tretman);
            //throw new NotImplementedException();
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
            Rezervacije.Add(rezervacija);
        }

        public static KozmetickiSalon getInstance()
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
            klijenti.Remove(klijent);
        }

        public void obrisiRezervaciju(Rezervacija rezervacija)
        {
            Rezervacije.Remove(rezervacija);
        }

        public void obrisiTretman(Tretman tretman)
        {
            tretmani.Remove(tretman);
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
            foreach(Tretman t in tretmani)
            {
                if(t.Id == tretman.Id)
                {
                    tretmani.Remove(t);
                    break;
                }
            }

            tretmani.Add(tretman);
        }

        //interfejs IKreirajIterator
        public void kreirajIterator(int vrsta, ICollection<Rezervacija> rezervacije)
        {
            if (vrsta == 0) {
                Iterator = new DatumVrijemeIterator(rezervacije);
            } else if(vrsta == 1)
            {
                Iterator = new UposlenikIterator(rezervacije);
            }
            //throw new NotImplementedException();
        }

        public void obavijestiKlijete(Tretman tretman)
        {
            Obavijest obavijest = new Obavijest();
            foreach(IKlijentObserver k in OKlijenti)
            {
                obavijest.DatumSlanja=DateTime.Now;
                obavijest.PorukaObavijesti = "Dodan je novi tretman " + tretman.NazivTretmana;
                obavijest.Tip = Obavijest.TipObavijesti.NoviTretman;
                k.update(obavijest);
            }
        }

        public void kopirajTretman(Tretman tretman, string naziv, string opis, double cijena)
        {
            OTretmani.Add(tretman.kloniraj(naziv, opis, cijena));
        }

        public void registrujSe(string ime, string prezime, string korisnickoIme, string lozinka, string eMailTelefon)
        {
            throw new NotImplementedException();
        }

        public void prijaviSe(string korisnickoIme, string lozinka)
        {
            throw new NotImplementedException();
        }

        public void aktivirajHitanSlucaj()
        {
            throw new NotImplementedException();
        }

        public void posaljiObavijest(Obavijest obavijest)
        {

            throw new NotImplementedException();
        }

        public void posaljiPoruku(Poruka poruka)
        {
            throw new NotImplementedException();
        }
    }
    
    
}
