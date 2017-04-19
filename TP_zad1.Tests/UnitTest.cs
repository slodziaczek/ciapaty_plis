using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace TP_zad1.Tests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void stworzKlientaTest()
        {
            DataRepository dr = new DataRepository();
            Klient k = new Klient("Emil", "Szczepaniak", "577960967", "emil.szczepaniak.it@gmail.com");

            //expected value: true
            Assert.IsTrue(dr.stworzKlienta(k));
            //expected value: false
            Assert.IsFalse(dr.stworzKlienta(k));
        }
        [TestMethod]
        public void dodajFilmTest()
        {
            DataRepository dr = new DataRepository();
            Film fl = new Film("Milczenie owiec", "Jonathan Demme", "Film kryminalny");

            Assert.IsTrue(dr.dodajFilm(fl));
            Assert.IsFalse(dr.dodajFilm(fl));

        }
        [TestMethod]
        public void dodajWypozyczenieTest()
        {
            DataRepository dr = new DataRepository();
            Klient klient = new Klient("Emil", "Szczepaniak", "577960967", "emil.szczepaniak.it@gmail.com");
            Film film = new Film("Milczenie owiec", "Jonathan Demme", "Film kryminalny");
            DateTime now = DateTime.Now;
            DateTime dt = now.AddDays(5);
            Wypozyczenie wyp = new Wypozyczenie(film, klient, dt);

            Assert.IsTrue(dr.dodajWypozyczenie(wyp));

            Assert.IsFalse(dr.dodajWypozyczenie(wyp));
        }
        [TestMethod]
        public void dodajStanTest()
        {
            DataRepository dr = new DataRepository();
            DateTime now = DateTime.Now;
            OpisStanu os = new OpisStanu("Hannibal Lecter", now.ToString());

            Assert.IsTrue(dr.dodajStan(os));

            Assert.IsFalse(dr.dodajStan(os));
        }
        [TestMethod]
        public void getKlientTest()
        {
            DataRepository dr = new DataRepository();
            Klient k = new Klient("Emil", "Szczepaniak", "577960967", "emil.szczepaniak.it@gmail.com");

            dr.stworzKlienta(k);

            //oczekiwana wartosc: true
            Assert.AreEqual(k, dr.getKlient(k));
        }
        //[TestMethod]
        //public void getFilmTestID()
        //{
        //    DataRepository dr = new DataRepository();
        //    int ID = 0; // czy to jest ok ? 
        //    dr.dodajFilm(ID);

        //    Assert.AreEqual(ID, dr.getFilm(ID));
        //}
        [TestMethod]
        public void getFilmTest()
        {
            DataRepository dr = new DataRepository();
            Film fl = new Film("Milczenie owiec", "Jonathan Demme", "Film kryminalny");

            dr.dodajFilm(fl);

            Assert.AreEqual(fl, dr.getFilm(fl));
        }
        [TestMethod]
        public void getOpisStanuTest()
        {
            DataRepository dr = new DataRepository();
            DateTime now = DateTime.Now;
            OpisStanu os = new OpisStanu("Hannibal Lecter", now.ToString());

            dr.dodajStan(os);
            Assert.AreEqual(os, dr.getOpisStanu(os));


        }
        [TestMethod]
        public void getWypozyczenieTest()
        {
            DataRepository dr = new DataRepository();
            Klient klient = new Klient("Emil", "Szczepaniak", "577960967", "emil.szczepaniak.it@gmail.com");
            Film film = new Film("Milczenie owiec", "Jonathan Demme", "Film kryminalny");
            DateTime now = DateTime.Now;
            DateTime dt = now.AddDays(5);
            Wypozyczenie wyp = new Wypozyczenie(film, klient, dt);

            dr.dodajWypozyczenie(wyp);

            Assert.AreEqual(wyp, dr.getWypozyczenie(wyp));

        }
        [TestMethod]
        public void usunKlientaTest()
        {
            DataRepository dr = new DataRepository();
            Klient klient = new Klient("Emil", "Szczepaniak", "577960967", "emil.szczepaniak.it@gmail.com");
            
            dr.stworzKlienta(klient);

            Assert.IsTrue(dr.usunKlienta(klient));

            Assert.IsFalse(dr.usunKlienta(klient));

        }
        //---------------------------------------PROBLEM Z KLUCZEM------------------------------------------
        //[TestMethod]                                                                                      |
        //public void usunFilmTest()                                                                        |
        //{                                                                                                 |
        //    DataRepository dr = new DataRepository();                                                     |
        //    Film fl = new Film("Milczenie owiec", "Jonathan Demme", "Film kryminalny");                   |
        //                                                                                                  |
        //    dr.dodajFilm(fl);                                                                             |
        //                                                                                                  |
        //    Assert.IsTrue(dr.usunFilm(fl));                                                               |
        //    Assert.IsFalse(dr.usunFilm(fl));                                                              |
        //}                                                                                                 |
        //--------------------------------------------------------------------------------------------------

        
                                                                                                         
        
        [TestMethod]
        public void usunOpisStanuTest()
        {
            DataRepository dr = new DataRepository();
            DateTime now = DateTime.Now;
            OpisStanu os = new OpisStanu("Hannibal Lecter", now.ToString());

            dr.dodajStan(os);

            Assert.IsTrue(dr.usunOpisStanu(os));

            Assert.IsFalse(dr.usunOpisStanu(os));

        }
        [TestMethod]
        public void usunWypozyczenieTest()
        {
            
            DataRepository dr = new DataRepository();
            Klient klient = new Klient("Emil", "Szczepaniak", "577960967", "emil.szczepaniak.it@gmail.com");
            Film film = new Film("Milczenie owiec", "Jonathan Demme", "Film kryminalny");
            DateTime now = DateTime.Now;
            DateTime dt = now.AddDays(5);
            Wypozyczenie wyp = new Wypozyczenie(film, klient, dt);

            dr.dodajWypozyczenie(wyp);

            Assert.IsTrue(dr.usunWypozecznie(wyp));

            Assert.IsFalse(dr.usunWypozecznie(wyp));

        }
        
    }
}
