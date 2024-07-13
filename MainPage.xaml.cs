namespace TempoDisco
{
    public partial class MainPage : ContentPage
    {
        #region Campos
        private List<Label> _listaEntradas = new List<Label>();
        #endregion

        #region Construtor
        public MainPage()
        {
            InitializeComponent();
            _listaEntradas.Add(ErroInicio);
            _listaEntradas.Add(ErroFim);
            _listaEntradas.Add(ErroSegmentos);
            _listaEntradas.Add(ErroHorizontal);
            _listaEntradas.Add(ErroVertical);
        }
        #endregion

        #region Método para Cálculo
        private void OnCalcular(object sender, EventArgs e)
        {
            TratamentoLabels();
            if (ConferirErros(_listaEntradas) == 0)
            {
                Tempo.Text = Operacores.TempoDeslocamento().ToString();
                Operacores.Zerar();
            }
            else
            {
                Tempo.Text = "NaN";
            }
        }
        #endregion

        #region Métodos Auxiliares
        private string AuxiliarTratamento(int numero)
        {
            if (numero == -1)
            {
                return "Valor inserido inválido.";
            }
            return "";
        }

        private int ConferirErros(List<Label> entrada)
        {
            int tamanhoLista = entrada.Count();
            for (int i = 0; i < tamanhoLista; ++i)
            {
                if (entrada[i].Text != "")
                {
                    return -1;
                }
            }
            return 0;
        }

        private void TratamentoLabels()
        {
            ErroInicio.Text = AuxiliarTratamento(Tratamentos.Inicio(Inicio.Text));
            ErroFim.Text = AuxiliarTratamento(Tratamentos.Fim(Fim.Text));
            ErroSegmentos.Text = AuxiliarTratamento(Tratamentos.Segmentos(SegmentosEntrada.Text));
            ErroHorizontal.Text = AuxiliarTratamento(Tratamentos.PesoHorizontal(PesoHorizontal.Text));
            ErroVertical.Text = AuxiliarTratamento(Tratamentos.PesoVertical(PesoVertical.Text));
        }
        #endregion
    }
}
