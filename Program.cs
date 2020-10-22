using System;
using System.Globalization;

using System.Collections.Generic;
using ExercicioHeranca.Entities;

namespace ExercicioHeranca
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> funcionario = new List<Funcionario>();

            Console.Write("Digite o número de funcionários que deseja registrar: ");
            int quantidade = int.Parse(Console.ReadLine());

            for (int i = 1; i <= quantidade; i++)
            {
                Console.WriteLine($"Funcionário {i}:");

                Console.Write("Terceirizado (s/n)?");
                char resp = char.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Horas: ");
                int horas = int.Parse(Console.ReadLine());
                Console.Write("Valor por hora: ");
                double valorPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (resp == 's')
                {
                    Console.Write("Despesa adicional: ");
                    double despesaAdicional = double.Parse(Console.ReadLine());

                    funcionario.Add(new FuncionarioTerceirizado(nome, horas, valorPorHora, despesaAdicional));
                }
                else
                {
                    funcionario.Add(new Funcionario(nome, horas, valorPorHora));
                }
            }

            Console.WriteLine();
            Console.WriteLine("Pagamentos: ");
            Console.WriteLine();

            foreach (Funcionario func in funcionario)
            {
                Console.WriteLine(func.Nome + " - $ " + func.Pagamento());
            }

        }
    }
}
