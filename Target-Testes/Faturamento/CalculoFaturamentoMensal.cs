using System;
using System.Collections.Generic;
using System.Linq;

namespace Target_Testes.Faturamento
{
    public class CalculoFaturamentoMensal
    {
        public static void CalculoFaturamentoMensalEstado()
        {
            List<FaturamentoMensal> fatMensal = new List<FaturamentoMensal>()

            {
            new FaturamentoMensal { Estado = "SP", ValorFaturamento = 6783643 },
            new FaturamentoMensal { Estado = "RJ", ValorFaturamento = 3667866 },
            new FaturamentoMensal { Estado = "MG", ValorFaturamento = 2922988 },
            new FaturamentoMensal { Estado = "ES", ValorFaturamento = 2716548 },
            new FaturamentoMensal { Estado = "Outros", ValorFaturamento = 1984953 },
        };

            var SomaValorFaturamento = fatMensal.Sum(x => x.ValorFaturamento);

            for (var i = 0; i < fatMensal.Count(); i++)
            {
                var valorFinal = fatMensal[i].ValorFaturamento * 100 / SomaValorFaturamento;
                var EstadoFinal = fatMensal[i].Estado;
                string strValorFinal = valorFinal.ToString("N2");


                Console.WriteLine($"Faturamento Mensal Estadual :  {EstadoFinal} : {strValorFinal}% ");
            }
        }
    }
}