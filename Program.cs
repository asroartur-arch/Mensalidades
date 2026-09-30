using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mensalidade
{
    using System;

    class Program
    {
        static void Main()
        {
            // Vetores de dados (NOMES TEMPORARIOS)
            string[] alunos = { "Nome1", "Nome2", "Nome3", "Nome4" };
            int[] anosEstudo = { 2, 7, 6, 1 };
            double[] mensalidadesBase = { 1000.00, 1000.00, 1200.00, 800.00 };

            Console.WriteLine("MENSALIDADES");

            // Lista todos
            for (int i = 0; i < alunos.Length; i++)
            {
                string nome = alunos[i];
                int anos = anosEstudo[i];
                double mensalidadeBase = mensalidadesBase[i];

                // Chamada de função com parâmetro por valor
                double desconto = CalcularDesconto(anos);

                double mensalidadeFinal = mensalidadeBase;

                // Chamada de função com parâmetro por ref (referencia)
                AplicarDesconto(mensalidadeBase, desconto, ref mensalidadeFinal);

                // dados
                Console.WriteLine($"\nAluno(a): {nome}");
                Console.WriteLine($"Tempo de estudo: {anos} ano(s)");
                Console.WriteLine($"Mensalidade Base: R$ {mensalidadeBase}");
                Console.WriteLine($"Desconto: {desconto * 100}%");
                Console.WriteLine($"Mensalidade Final: R$ {mensalidadeFinal}");
            }
        }

        // Função fora do Main com retorno e parâmetro por valor
        public static double CalcularDesconto(int anos)
        {
            // Desconto se o aluno estudou mais de 5 anos
            if (anos > 5)
            {
                return 0.20; // 20% de desconto
            }
            return 0.0; // Sem desconto
        }

        // função fora do Main (public static) sem retorno (void) e parâmetro por ref (referencia
        public static void AplicarDesconto(double valorBase, double percDesconto, ref double valorFinal)
        {
            // Valor depois do desconto
            valorFinal = valorBase - (valorBase * percDesconto);
        }
    }
}
