using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace _60._Exercicio_de_fixacao
{
    class ContaBancaria
    {
        public int NumeroConta { get; private set; }
        public string NomeTitular { get;  set; } // é possível alterar o nome
        public double Saldo { get; private set; } // só pode ser alterado por deposito ou saque

        public ContaBancaria(int numeroConta, string nomeTitular)
        {
            NumeroConta = numeroConta;
            NomeTitular = nomeTitular;
            Saldo = 0.0;
        }
        public ContaBancaria(int numeroConta, string nomeTitular, double depositoInicial) : this(numeroConta, nomeTitular){
            Deposito(depositoInicial); 
        }
        public void Deposito (double valor)
        {
            Saldo += valor;
        }
        public void Saque (double valor)
        {
            Saldo -= valor + 5.00;
        }
        public override string ToString()
        {
            return "Conta "
                + NumeroConta
                + " , Titular: "
                + NomeTitular
                + " , Saldo: $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }



    }
}
