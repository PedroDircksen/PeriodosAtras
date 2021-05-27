using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodosAtras
{
    public class Temporizador 
    {
        readonly ConversorHoras conversorHoras = new ConversorHoras();
        public DateTime dataComTempo;
        public DateTime dataAtualTemporizada = new DateTime(2021, 05, 26, 23, 50, 25);

        public double totalSegundos, restoTotalSegundos;
        public double horasDecorridas, restoHorasDecorridas;
        public double minutosDecorridos, restoMinutosDecorridos;
        public double segundosDecorridos;

        public string resultadoTempo = null;

        public  Temporizador (DateTime th)
        {
            dataComTempo = th;

            if (dataComTempo > dataAtualTemporizada)
            {
                resultadoTempo = "Data no Futuro";
            }
            else
            {
                SeparadorDatasComTempo();
                EscrevedorDatasComTempo();
            }
        }
        private void SeparadorDatasComTempo()
        {
            totalSegundos = conversorHoras.TransformarHorasEmSegundosTotaisDecorridos(this);
            horasDecorridas = conversorHoras.TransformarSegundosTotaisEmHorasDecorridas(this);
            minutosDecorridos = conversorHoras.TransformarHorasEmMinutosDecorridos(this);
            segundosDecorridos = conversorHoras.TransformarHorasEmSegundosDecorridos(this);
        }

        private void EscrevedorDatasComTempo()
        {
            resultadoTempo = conversorHoras.EscreveNumeroAteDoisDigitosTempo(horasDecorridas);
            if (horasDecorridas >= 1)
            {
                if (horasDecorridas == 1)
                    resultadoTempo += "hora ";
                else
                    resultadoTempo += "horas ";

                if (minutosDecorridos != 0 || segundosDecorridos != 0)
                    resultadoTempo += "e ";
            }

            resultadoTempo += conversorHoras.EscreveNumeroAteDoisDigitosTempo(minutosDecorridos);
            if (minutosDecorridos >= 1)
            {
                if (minutosDecorridos == 1)
                    resultadoTempo += "minuto ";
                else
                    resultadoTempo += "minutos ";

                if (segundosDecorridos != 0)
                    resultadoTempo += "e ";
            }

            resultadoTempo += conversorHoras.EscreveNumeroAteDoisDigitosTempo(segundosDecorridos);
            if (segundosDecorridos >= 1)
            {
                if (segundosDecorridos == 1)
                    resultadoTempo += "segundo ";
                else
                    resultadoTempo += "segundos ";
            }
            if (resultadoTempo != null && dataComTempo != dataAtualTemporizada)
                resultadoTempo += "atrás";
        }

    }
}
