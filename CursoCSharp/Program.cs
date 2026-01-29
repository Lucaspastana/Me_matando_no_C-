using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentarios - Fundamentos ", Comentarios.Executar },
                {"Variaveis e Constantes - Fundamentos ", VariaveisEConstantes.Executar },
                {"Inferencia - Fundamentos ", Inferencia.Executar },
                {"Interpolacao - Fundamentos ", Interpolacao.Executar},
                {"Notacao Ponto - Fundamentos ", NotacaoPonto.Executar},
                {"Lendo dados- Fundamentos ", LendoDados.Executar},
                {"Formatando Numero- Fundamentos ", FormatandoNumero.Executar},
                {"Convercao- Fundamentos ", Convercao.Executar},
                {"Operadores  Aritmetico- Fundamentos ", OperadoresAritmetico.Executar},
                {"Operadores Relacionais- Fundamentos ", OperadoresRelacionais.Executar},
                {"Operadores Logicos Relacionais- Fundamentos ", OperadoresLogicos.Executar},


            });

            central.SelecionarEExecutar();
        }
    }
}