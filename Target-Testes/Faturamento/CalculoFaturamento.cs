using System;
using System.Collections.Generic;
using System.Linq;

namespace Target_Testes.Faturamento
{
    public class CalculoFaturamento
    {
        public static void CalcularFaturamentoMensal()
        {
            List<FaturamentoDiario> fatDiario = new List<FaturamentoDiario>
            {
             new FaturamentoDiario { RegistroFaturamentoId = 2223 ,  DiaFaturamento = new DateTime(2008,01,29) , ValorFaturamento = 2000 , isFeriadoOuFinalDeSemana = false},
             new FaturamentoDiario { RegistroFaturamentoId = 21223 ,DiaFaturamento = new DateTime(2008,02,29) , ValorFaturamento = 12000, isFeriadoOuFinalDeSemana = false },
             new FaturamentoDiario {RegistroFaturamentoId = 2129, DiaFaturamento = new DateTime(2008,03,29) , ValorFaturamento = 12900,isFeriadoOuFinalDeSemana = false },
             new FaturamentoDiario {RegistroFaturamentoId = 212911, DiaFaturamento = new DateTime(2008,04,29) , ValorFaturamento = 212900, isFeriadoOuFinalDeSemana = false },
             new FaturamentoDiario {RegistroFaturamentoId = 2129, DiaFaturamento = new DateTime(2008,05,29) , ValorFaturamento = 1000, isFeriadoOuFinalDeSemana = true},
             new FaturamentoDiario {RegistroFaturamentoId = 212911, DiaFaturamento = new DateTime(2008,04,29) , ValorFaturamento = 20 ,isFeriadoOuFinalDeSemana = true},
            };

            List<int> FaturamentoDiarioDiasUteis = new List<int>();

            FaturamentoDiarioDiasUteis = fatDiario.Where(x => x.isFeriadoOuFinalDeSemana == false).Select( x => x.ValorFaturamento).ToList();

            var MaiorFaturamento = FaturamentoDiarioDiasUteis.Max();
            var MenorFaturamento = FaturamentoDiarioDiasUteis.Min();
            var SomaMediaAnual = FaturamentoDiarioDiasUteis.Sum();
            var MediaAnual = SomaMediaAnual / FaturamentoDiarioDiasUteis.Count();

            var FaturamentoDSuperiorAnual = fatDiario.Where(x => x.ValorFaturamento > SomaMediaAnual).Select(x => x.DiaFaturamento).Count();





            Console.WriteLine($"O Maior  Faturamento Do Ano {MaiorFaturamento}");
            Console.WriteLine($"O Menor  Faturamento Do Ano {MaiorFaturamento}");
            Console.WriteLine($"Número de dias no ano em que o valor de faturamento diário foi superior à média anual : {FaturamentoDSuperiorAnual}");
        }
    }
}