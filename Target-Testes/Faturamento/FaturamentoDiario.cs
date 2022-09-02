using System;

namespace Target_Testes.Faturamento
{
    public class FaturamentoDiario
    {
        public int RegistroFaturamentoId { get; set; }
        public DateTime DiaFaturamento { get; set; }
        public int ValorFaturamento { get; set; }

        public bool isFeriadoOuFinalDeSemana { get; set; }
    }
}