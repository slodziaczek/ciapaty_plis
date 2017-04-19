using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;

namespace TP_zad1
{
    public class DataService
    {

        public DataService(DataRepository dataRepo)
            {
                this.dataRepo = dataRepo;
                this.dataRepo.Wypozyczenia.CollectionChanged += new NotifyCollectionChangedEventHandler(CollectionChangedMethod);

            }

        private DataRepository dataRepo;


        private void CollectionChangedMethod(object s, NotifyCollectionChangedEventArgs evnt)
        {
            if (evnt.Action.Equals(NotifyCollectionChangedAction.Add))
            {
                foreach (Wypozyczenie wyp in evnt.NewItems)
                {
                    Console.WriteLine("New rent added: " + wyp.WypiszWypozyczenia());
                }
            }
            if (evnt.Action.Equals(NotifyCollectionChangedAction.Remove))
            {
                foreach (Wypozyczenie wyp in evnt.OldItems)
                {
                    Console.WriteLine("Rent removed");
                }
            }
        }


    }
}
