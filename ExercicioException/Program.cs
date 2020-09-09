using ExercicioException.Entidades;
using ExercicioException.Entidades.Exception;
using System;
using System.Globalization;

namespace ExercicioException
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados da conta");
            Console.Write("Numero: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Titular: ");
            String titular = Console.ReadLine();
            Console.Write("Saldo inicial: ");
            double saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Limite de saque: ");
            double saqueLimite = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Conta cont = new Conta(numero, titular, saldo, saqueLimite);

            Console.WriteLine();
            Console.Write("Entre com o valor de saque: ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            try
            {
                cont.Saque(valor);
                Console.WriteLine("Novo saldo: " + cont.Saldo.ToString("F2", CultureInfo.InvariantCulture));
            }
            catch (Dominio e)
            {
                Console.WriteLine("Erro no saque: " + e.Message);
            }
        }
    }
}
   
