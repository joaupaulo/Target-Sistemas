using System;

namespace Target_Testes.VelocidadeMedia
{
    public class CalculoVM
    {
        public static void EquacaoHoraria()
        {
            var Tincial = 100 / 80;
            var T = 1.25 + 0.17;

            var VelocidadeMedia = 100 / T;

            var PontoCruzamento = 110 * 100 / 110 + 70.6;

            Console.WriteLine($"Essa é a distância da cidade de Ribeirão Preto {PontoCruzamento}");
        }
    }
}