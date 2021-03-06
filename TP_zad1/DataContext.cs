﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_zad1
{
    public class DataContext
    {
        public DataContext()
        {
            klienci = new List<Klient>();
            filmy = new Dictionary<int, Film>();
            opisyStanow = new List<OpisStanu>();
            wypozyczenia = new ObservableCollection<Wypozyczenie>();
            
        }

        public List<Klient> klienci;
        public Dictionary<int, Film> filmy;
        public ObservableCollection<Wypozyczenie> wypozyczenia;
        public List<OpisStanu> opisyStanow;

    }
}
