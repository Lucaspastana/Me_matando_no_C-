using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class LendoDados
    {
        public static void Executar()
        {
            Console.Write("Qual o seu nome ");
            string nome = Console.ReadLine();

            Console.Write("Qual é a sua idade ");
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Qual seu salario ?");
            double salario = double.Parse(Console.ReadLine(),
                CultureInfo.InvariantCulture);

            Console.WriteLine($"Ola meu nome é {nome} e eu tenho {idade} ganho {salario} ");
        }
    }
}
