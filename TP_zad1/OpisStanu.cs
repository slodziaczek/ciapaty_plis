using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_zad1
{
    public class OpisStanu
    {
      //  private static int id = 0;

        public OpisStanu(string opisFilmu, string dataZakupu)
        {
            //id = ++id;
            _opisFilmu = opisFilmu;
            _dataZakupu = dataZakupu;
        }


        private string _opisFilmu { get; set; }
        private string _dataZakupu { get; set; }

        public string wyswietlOpisStanu()
        {
            Console.WriteLine("Opis stanu: ");

            return ("Opis filmu " + _opisFilmu + "  data zakupu: " + _dataZakupu + "\n");

        }
    }
}

