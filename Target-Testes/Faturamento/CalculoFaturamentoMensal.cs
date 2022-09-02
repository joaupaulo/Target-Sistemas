using System;
using System.Linq;

namespace Target_Testes.Faturamento
{
    public class CalculoFaturamentoMensal
    {
        public void CalculoFaturamentoMensalEstado()
        {
            FaturamentoMensal[] fatMensal = new FaturamentoMensal[6];
            {
                new FaturamentoMensal { Estado = "SP", ValorFaturamento = 67.83643 };
                new FaturamentoMensal { Estado = "RJ", ValorFaturamento = 36.67866 };
                new FaturamentoMensal { Estado = "MG", ValorFaturamento = 29.22988 };
                new FaturamentoMensal { Estado = "ES", ValorFaturamento = 27.16548 };
                new FaturamentoMensal { Estado = "Outros", ValorFaturamento = 1984953 };
            };

          var SomaValorFaturamento =  fatMensal.Sum(x => x.ValorFaturamento);

            for (var i = 0; i < fatMensal.Length; i++ )
            {
                var valorFinal = fatMensal[i].ValorFaturamento* 100 / SomaValorFaturamento;
                var EstadoFinal = fatMensal[i].Estado;

                Console.WriteLine($"Faturamento Mensal Estadual :  {EstadoFinal}");
            } 
        }


       
    }
}