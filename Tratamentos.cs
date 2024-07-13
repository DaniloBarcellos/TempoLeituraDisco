using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempoDisco
{
    static class Tratamentos
    {
        #region Métodos para Tratamento
        public static int Inicio(string inicio)
        {
            if (AuxiliarTratamento(inicio) != -1)
            {
                Operacores.Inicio = AuxiliarTratamento(inicio);
                return 0;
            }
            return -1;
        }

        public static int Fim(string fim)
        {
            int fimNumero = AuxiliarTratamento(fim);
            if (fimNumero != -1 && fimNumero != Operacores.Inicio)
            {
                Operacores.Fim = fimNumero;
                return 0;
            }
            return -1;
        }

        public static int Segmentos(string segmentos)
        {
            int segmentosNumero = AuxiliarTratamento(segmentos);
            if (segmentosNumero != -1 && segmentosNumero > 0 )
            {
                Operacores.Segmentos = segmentosNumero;
                return 0;
            }
            return -1;
        }

        public static int PesoHorizontal(string peso)
        {
            float pesoNumero = AuxiliarTratamentoPesos(peso);
            if (pesoNumero != -1)
            {
                Operacores.PesoHorizontal = pesoNumero;
                return 0;
            }
            return -1;
        }

        public static int PesoVertical(string peso)
        {
            float pesoNumero = AuxiliarTratamentoPesos(peso);
            if (pesoNumero != -1)
            {
                Operacores.PesoVertical = pesoNumero;
                return 0;
            }
            return -1;
        }
        #endregion

        #region Métodos Auxiliares
        private static int AuxiliarTratamento(string entrada)
        {
            int numeroFinal;
            try
            {
                numeroFinal = int.Parse(entrada);
                if (numeroFinal < 0)
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                return -1;
            }
            return numeroFinal;
        }

        private static float AuxiliarTratamentoPesos(string entrada)
        {
            float numeroFinal;
            try
            {
                numeroFinal = float.Parse(entrada);
                if (numeroFinal <= 0)
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                return -1;
            }
            return numeroFinal;
        }
        #endregion
    }
}
