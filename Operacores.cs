using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempoDisco
{
    class Operacores
    {
        #region Campos
        private static int _inicio;
        private static int _fim;
        private static int _segmentos;
        private static float _pesoHorizontal;
        private static float _pesoVertical;
        #endregion

        #region Acesso aos Campos
        public static int Inicio { get { return _inicio; } set { _inicio = value; } }
        public static int Fim { get { return _fim; } set { _fim = value; } }
        public static int Segmentos { get { return _segmentos; } set { _segmentos = value; } }
        public static float PesoHorizontal { get { return _pesoHorizontal; } set { _pesoHorizontal = value; } }
        public static float PesoVertical { get { return _pesoVertical; } set { _pesoVertical = value; } }
        #endregion

        #region Métodos para Operações
        static private float DeslocamentoHorizontal()
        { 
            if (_fim < _inicio)
            {
                return Math.Abs(((Math.Abs(_inicio - _fim) % _segmentos) * _pesoHorizontal) - _segmentos);
            }
            else
            {
                return (Math.Abs(_inicio - _fim) % _segmentos) * _pesoHorizontal;
            }
        }

        static private float DeslocamentoVertical()
        {
            return Math.Abs((int)_inicio / _segmentos - (int)_fim / _segmentos) * _pesoVertical;
        }

        static public float TempoDeslocamento()
        {
            return DeslocamentoHorizontal() + DeslocamentoVertical();
        }
        #endregion

        #region Métodos Auxiliares
        public static void Zerar()
        {
            _inicio = _fim = _segmentos =  -1;
            _pesoHorizontal = _pesoVertical = 0;
        }
        #endregion

    }
}
