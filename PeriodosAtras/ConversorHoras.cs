using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodosAtras
{
    class ConversorHoras
    {
        public double TransformarHorasEmSegundosTotaisDecorridos(Temporizador datath)
        {
            return (datath.dataAtualTemporizada - datath.dataComTempo).TotalSeconds;            
        }
        public double TransformarSegundosTotaisEmHorasDecorridas(Temporizador datath)
        {
            datath.restoTotalSegundos = datath.totalSegundos % 3600;
            return datath.horasDecorridas = datath.totalSegundos / 3600;
        }
        public double TransformarHorasEmMinutosDecorridos(Temporizador datath)
        {
            datath.restoHorasDecorridas = datath.restoTotalSegundos % 60;
            return datath.minutosDecorridos = datath.restoTotalSegundos / 60;
        }
        public double TransformarHorasEmSegundosDecorridos(Temporizador datath)
        {
            return datath.segundosDecorridos = datath.restoHorasDecorridas;
        }

        public string EscreveNumeroAteDoisDigitosTempo(double valor)
        {
            Dictionary<char, string> unidades, teens, dezenas;
            GerarDictionaryNumerosPorExtensos(out unidades, out teens, out dezenas);

            string montagem = string.Empty;
            string strValor = valor.ToString("00");
            char a = Convert.ToChar(strValor.Substring(0, 1));
            char b = Convert.ToChar(strValor.Substring(1, 1));


            if (a == '1')
                montagem += teens[b] + " ";
            else
            {
                if (dezenas.ContainsKey(a))
                    montagem += dezenas[a] + ((b != '0') ? " e " : " ");

                if (unidades.ContainsKey(b))
                    montagem += unidades[b] + " ";
            }
            return montagem;
        }

        private static void GerarDictionaryNumerosPorExtensos(out Dictionary<char, string> unidades, out Dictionary<char, string> teens, out Dictionary<char, string> dezenas)
        {
            unidades = new Dictionary<char, string>();
            unidades.Add('1', "um");
            unidades.Add('2', "dois");
            unidades.Add('3', "três");
            unidades.Add('4', "quatro");
            unidades.Add('5', "cinco");
            unidades.Add('6', "seis");
            unidades.Add('7', "sete");
            unidades.Add('8', "oito");
            unidades.Add('9', "nove");

            teens = new Dictionary<char, string>();
            teens.Add('0', "dez");
            teens.Add('1', "onze");
            teens.Add('2', "doze");
            teens.Add('3', "treze");
            teens.Add('4', "quatorze");
            teens.Add('5', "quinze");
            teens.Add('6', "dezesseis");
            teens.Add('7', "dezessete");
            teens.Add('8', "dezoito");
            teens.Add('9', "dezenove");

            dezenas = new Dictionary<char, string>();
            dezenas.Add('2', "vinte");
            dezenas.Add('3', "trinta");
            dezenas.Add('4', "quarenta");
            dezenas.Add('5', "cinquenta");
            dezenas.Add('6', "sessenta");
            dezenas.Add('7', "setenta");
            dezenas.Add('8', "oitenta");
            dezenas.Add('9', "noventa");
        }

    }
}
