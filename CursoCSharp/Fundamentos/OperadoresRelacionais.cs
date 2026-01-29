using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class OperadoresRelacionais
    {
         public static void Executar(){
            double nota = 6.5;
            double notadecorte = 7.0;

            Console.WriteLine("Nota invalida {0}",nota > 10);
            Console.WriteLine("Nota invalida {0}",nota < 0.0);
            Console.WriteLine("Perfeito ? {0}",nota ==10.0);
            Console.WriteLine("Tem como melhorar ? {0}",nota != 10.0);
            Console.WriteLine("Passou por média ? {0}", nota >=notadecorte);
            Console.WriteLine("Recuperação? {0}", nota < notadecorte);
            Console.WriteLine("Reprovado {0}", nota <= 3.0);

        }
    }
}
