using System;
using Target_Testes.Faturamento;
using Target_Testes.VelocidadeMedia;

namespace Target_Testes
{
    class Program
    {
        static void Main(string[] args)
        {
           CalculoFaturamento.CalcularFaturamentoMensal();
            CalculoFaturamentoMensal.CalculoFaturamentoMensalEstado();
            SomaDeNumeros.SomaNum();
            Fibonnaci.FibonnaciSequencie();
            CalculoVM.EquacaoHoraria();
        }
    }
}
