using System;
using System.Collections.Generic;
using System.Linq;

namespace Target_Testes.Faturamento
{
    public class CalculoFaturamento
    {
        public void CalcularFaturamentoMensal()
        {
            List<FaturamentoDiario> fatDiario = new List<FaturamentoDiario>
            {
             new FaturamentoDiario { RegistroFaturamentoId = 2223 ,  DiaFaturamento = new DateTime(2008,01,29) , ValorFaturamento = 2000 , isFeriadoOuFinalDeSemana = false},
             new FaturamentoDiario { RegistroFaturamentoId = 21223 ,DiaFaturamento = new DateTime(2008,02,29) , ValorFaturamento = 12000, isFeriadoOuFinalDeSemana = false },
             new FaturamentoDiario {RegistroFaturamentoId = 2129, DiaFaturamento = new DateTime(2008,03,29) , ValorFaturamento = 12900,isFeriadoOuFinalDeSemana = false },
             new FaturamentoDiario {RegistroFaturamentoId = 212911, DiaFaturamento = new DateTime(2008,04,29) , ValorFaturamento = 212900, isFeriadoOuFinalDeSemana = false },
             new FaturamentoDiario {RegistroFaturamentoId = 2129, DiaFaturamento = new DateTime(2008,03,29) , ValorFaturamento = 1000, isFeriadoOuFinalDeSemana = true},
             new FaturamentoDiario {RegistroFaturamentoId = 212911, DiaFaturamento = new DateTime(2008,04,29) , ValorFaturamento = 20 ,isFeriadoOuFinalDeSemana = true},
            };

            List<FaturamentoDiario> FaturamentoDiarioDiasUteis = new List<FaturamentoDiario>();

            FaturamentoDiarioDiasUteis.Where(x => x.isFeriadoOuFinalDeSemana == false).Select(x => x.ValorFaturamento);

            var MaiorFaturamento = FaturamentoDiarioDiasUteis.Max(x => x.ValorFaturamento);
            var MenorFaturamento = FaturamentoDiarioDiasUteis.Min(x => x.ValorFaturamento);
            var SomaMediaAnual = FaturamentoDiarioDiasUteis.Sum(x => x.ValorFaturamento);
            var MediaAnual = SomaMediaAnual / FaturamentoDiarioDiasUteis.Count();

            var FaturamentoDSuperiorAnual = FaturamentoDiarioDiasUteis.Where(x => x.ValorFaturamento > SomaMediaAnual).Select(x => x.DiaFaturamento).Count();

            Console.WriteLine($"O Maior  Faturamento Do Ano {MaiorFaturamento}");
            Console.WriteLine($"O Menor  Faturamento Do Ano {MaiorFaturamento}");
            Console.WriteLine($"Número de dias no ano em que o valor de faturamento diário foi superior à média anual : {FaturamentoDSuperiorAnual}");
        }
    }
}