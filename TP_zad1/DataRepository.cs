using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_zad1
{
    public class DataRepository
    {
        public DataRepository()
        {
            dataContext = new DataContext();
        }

        public DataContext dataContext { get; set; }



        public DataRepository(Interfejs interfejs)
        {
            dataContext = new DataContext();

            //ws.WypelnijListeKlientow(this);
            //ws.WypelnijSlownikFilmow(this);
            //ws.WypelnijKolekcjeWypozyczen(this);
            //ws.WypelnijListeOpisowStanow(this);

            interfejs.WypelnijListeKlientow(this);
            interfejs.WypelnijSlownikFilmow(this);
            interfejs.WypelnijKolekcjeWypozyczen(this);
            interfejs.WypelnijListeOpisowStanow(this);

        }
        //-------------PRZETESTOWANA-----------------------
        public bool stworzKlienta(Klient kl)
        {
            if (!dataContext.klienci.Contains(kl)) //as not to duplicate information
            {
                dataContext.klienci.Add(kl);
                return true;
            }
            return false;
        }
        //-------------PRZETESTOWANA-----------------------
        public bool dodajFilm(Film fl)
        {
            if (!dataContext.filmy.ContainsValue(fl)) //as to avoid runtime error
            {
                dataContext.filmy.Add(dataContext.filmy.Count + 1, fl);
                return true;
            }
            return false;
        }
        //-------------PRZETESTOWANA-----------------------
        public bool dodajWypozyczenie(Wypozyczenie wyp)
        {
            if (!dataContext.wypozyczenia.Contains(wyp))
            {
                dataContext.wypozyczenia.Add(wyp);
                return true;
            }
            return false;
        }
        //-------------PRZETESTOWANA-----------------------
        public bool dodajStan(OpisStanu os)
        {
            if (!dataContext.opisyStanow.Contains(os)) //as not to duplicate information
            {
                dataContext.opisyStanow.Add(os);
                return true;
            }
            return false;
        }

        //-------------PRZETESTOWANA-----------------------
        public Klient getKlient(Klient k)
        {
            if (dataContext.klienci.Contains(k))
            {
                foreach (Klient klient in dataContext.klienci)
                {
                    if (klient == k) return k;
                }
            }
            return null;
        }
        
        public Film getFilm(int ID) //<------------------------------------------DO PRZETESTOWANIA
        {
            if (dataContext.filmy.ContainsKey(ID))
            {
                foreach (int id in dataContext.filmy.Keys)                           
                {
                    if (id.Equals(ID)) return dataContext.filmy[id];
                }
            }
            return null;
        }
        //-------------PRZETESTOWANA-----------------------
        public Film getFilm(Film fl)
        {
            if (dataContext.filmy.ContainsValue(fl))
            {
                foreach (Film value in dataContext.filmy.Values)
                {
                    if (fl._tytul.Equals(value._tytul)) return value;
                }
            }
            return null;
        }
        //-------------PRZETESTOWANA-----------------------
        public OpisStanu getOpisStanu(OpisStanu os)
        {
            if (dataContext.opisyStanow.Contains(os))
            {
                foreach (OpisStanu stan in dataContext.opisyStanow)
                {
                    if (stan == os) return os;
                }
            }
            return null;
        }

        //-------------PRZETESTOWANA-----------------------
        public Wypozyczenie getWypozyczenie(Wypozyczenie wyp)
        {
            if (dataContext.wypozyczenia.Contains(wyp))
            {
                foreach (Wypozyczenie wypozyczenie in dataContext.wypozyczenia)
                {
                    if (wypozyczenie == wyp) return wyp;
                }
            }
            return null;
        }

        public List<Klient> getKlienci() //<------------------------------------------DO PRZETESTOWANIA
        {
            return dataContext.klienci;
        }

        public Dictionary<int, Film> getFilmy()
        {
            return dataContext.filmy;
        }

        public ObservableCollection<Wypozyczenie> Wypozyczenia  //<------------------------------------------DO PRZETESTOWANIA
        {
            get
            {
                return dataContext.wypozyczenia;
            }
            
        }

        public List<OpisStanu> getOpisyStanow()
        {
            return dataContext.opisyStanow;
        }

        //-------------PRZETESTOWANA-----------------------
        public bool usunKlienta(Klient kl) 
        {
            foreach (Klient klient in dataContext.klienci)
            {
                if (klient == kl)
                {
                    dataContext.klienci.Remove(kl);
                    return true;
                }
            }
            return false;
        }


        public bool usunFilm(Film fl)//<------------------------------------------DO PRZETESTOWANIA
        {
            foreach (KeyValuePair<int, Film> film in dataContext.filmy)
            {
                if (film.Value._tytul == fl._tytul)
                {
                    dataContext.filmy.Remove(film.Key);
                }
            }

            return false;
        }
        //-------------PRZETESTOWANA-----------------------
        public bool usunOpisStanu(OpisStanu os)
        {
            foreach (OpisStanu opisStanu in dataContext.opisyStanow)
            {
                if (opisStanu == os)
                {
                    dataContext.opisyStanow.Remove(os);
                    return true;
                }
            }
            return false;
        }
        //-------------PRZETESTOWANA-----------------------
        public bool usunWypozecznie(Wypozyczenie wyp)
        {
            foreach (Wypozyczenie wypozyczenie in dataContext.wypozyczenia)
            {
                if (wypozyczenie == wyp) dataContext.wypozyczenia.Remove(wyp);
                return true;
            }
            return false;
        }

    }

    }
