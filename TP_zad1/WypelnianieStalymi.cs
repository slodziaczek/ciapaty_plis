using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_zad1
{
    public class WypelnianieStalymi : Interfejs
    {
        public void WypelnijKolekcjeWypozyczen(DataRepository dataRepo)
        {
            DateTime now = DateTime.Now;
            DateTime dt = now.AddDays(5);
            {
                for (int i = 0; i < dataRepo.dataContext.filmy.Count; i++)
                {
                    dataRepo.dodajWypozyczenie(new Wypozyczenie(dataRepo.dataContext.filmy[i + 1], dataRepo.dataContext.klienci[i], dt));
                    Console.WriteLine(dataRepo.dataContext.wypozyczenia[i].WypiszWypozyczenia());
                }
            }
        }

        public void WypelnijListeKlientow(DataRepository dataRepo)
        {
            Klient kl = new Klient("Emil", "Szczepaniak", "577960967", "emil.szczepaniak.it@gmail.com");
            dataRepo.stworzKlienta(kl);
            Console.WriteLine(kl.wyswietlKlienta());

        }

        public void WypelnijListeOpisowStanow(DataRepository dataRepo)
        {
            OpisStanu opisStanu = new OpisStanu("zajebista ksiazka", "o Twojej starej");
            dataRepo.dodajStan(opisStanu);
            Console.WriteLine(opisStanu.wyswietlOpisStanu());
        }

        public void WypelnijSlownikFilmow(DataRepository dataRepo)
        {
            Film film = new Film("Twoja stara", "Twoj Stary", "zubr");
            dataRepo.dodajFilm(film);
            Console.WriteLine(film.wyswietlFilmy());
        }
    }
}
