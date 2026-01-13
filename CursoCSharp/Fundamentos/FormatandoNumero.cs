using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    internal class FormatandoNumero
    {
        public static void Executar()
        {
            double valor = 15.1758548395793485;
            Console.WriteLine(valor.ToString("F1")); //CASAS DECIMAIS
            Console.WriteLine(valor.ToString("C")); //COINS tranforma na moeda local
            Console.WriteLine(valor.ToString("P"));// coloca em porcentagem e multiplica por 100
            Console.WriteLine(valor.ToString("#.#####")); // casa decimais também

            CultureInfo cultura = new CultureInfo("pt-BR");
            Console.WriteLine(valor.ToString("C3", cultura));
        }
    }
}
