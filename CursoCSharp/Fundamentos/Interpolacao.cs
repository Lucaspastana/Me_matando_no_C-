using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class Interpolacao
    {
        public static void Executar()
        {
            string nome = "Volvo c16";
            int preco = 150000;
            string modelo = "USV";
            //TIPOS DE FAZER CONCATENAÇÃO DE STRINGS !!
            Console.WriteLine("Tenho um carro " + nome +" ele me custou " + preco+ " e o modelo dele e "+ modelo);
            Console.WriteLine("o {0} do modelo {1} custou {2}", nome, modelo,preco);
            Console.WriteLine($"A marca {nome} é legal");
            Console.WriteLine($"1 + 1 =  {1+1}!");


        }
    }
}
