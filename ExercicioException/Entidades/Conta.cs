using ExercicioException.Entidades.Exception;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioException.Entidades
{
    class Conta
    {
        public int Numero { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }
        public double SaqueLimite { get; set; }

        public Conta()
        {
        }

        public Conta(int numero, string titular, double saldo, double saqueLimite)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
            SaqueLimite = saqueLimite;
        }

        public void Deposito(double valor)
        {
            Saldo += valor;
        }

        public void Saque(double valor)
        {
            if (valor > SaqueLimite)
            {
                throw new Dominio("A quantia excedeu o limite de saque...");
            }
            if (valor > Saldo)
            {
                throw new Dominio("Não há saldo suficiente");
            }

            Saldo -= valor;
        }
    }
}

