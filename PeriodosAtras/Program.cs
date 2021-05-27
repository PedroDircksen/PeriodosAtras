using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodosAtras
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dataTempo = new DateTime(2021,05,26,14,26,48);
            DateTime dataData = new DateTime(2014, 04, 16);
            Data data = new Data(dataData);
            Temporizador temporizador = new Temporizador(dataTempo);

            Console.WriteLine(data.resultado.ToUpper() + "\n");
            Console.WriteLine(temporizador.resultadoTempo.ToUpper());

            Console.ReadLine();
        }
    }
}
