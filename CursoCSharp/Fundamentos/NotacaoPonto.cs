using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class NotacaoPonto
    {
        public static void Executar()
        {

            var saudaco = "olá".ToUpper().Insert(3, "World").Replace("World", "Mundo");//o replace tira o world e add o "mundo"
            Console.WriteLine(saudaco);
            Console.WriteLine("Teste".Length);

            string valorimportante = null;
            //o ? é usado para que só quando a vavriavel acima estiver valor tendo uma navegação segura.
            Console.WriteLine(valorimportante?.Length);



        }
    }
}
