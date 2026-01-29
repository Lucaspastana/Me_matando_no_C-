using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class OperadoresLogicos
    {
        public static void Executar()
        {
            var Dia1 = true;
            var Dia2 = false;

            bool ComprarTv50 = Dia1 && Dia2;
            Console.Write("Comprou a TV ? {0}", ComprarTv50);

            var TomouSorvete = Dia1 || Dia2;
            Console.Write("Tomamos{0}", TomouSorvete);

            var ComprouPC = Dia1 ^ Dia2;
            Console.Write("Comprou o PC {0}", ComprouPC);

        }

    }
}
