using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_zad1
{
    class Program
    {
        static void Main(string[] args)
        {

            //DateTime time = DateTime.Now;
            //Console.WriteLine(time.ToString("dd/MM/yyyy"));
            //DateTime chuj = time.AddDays(5);
            //Console.WriteLine(chuj.ToString("dd/MM/yyyy"));


            WypelnianieStalymi ws = new WypelnianieStalymi();
            DataRepository dr = new DataRepository(ws);

            

            Console.ReadKey();

        }
    }
}
