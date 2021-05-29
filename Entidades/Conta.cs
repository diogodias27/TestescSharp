using System;
using System.Collections.Generic;
using System.Text;

namespace Bank_Dio
{
    public class Conta
    {
        private TipoConta TipoConta { get; set; }
        private double Saldo { get; set; }
        private double Credito { get; set; }
        private string Nome { get; set; }

        public Conta(TipoConta tipoConta, double saldo, double credito, string nome)
        {
            this.TipoConta = tipoConta;
            this.Saldo = saldo;
            this.Credito = credito;
            this.Nome = nome;
        }

        public bool Sacar (double valorSaque)
        {
            if (this.Saldo - valorSaque <(this.Credito *-1))
            {
                Console.WriteLine("Saldo insufiente!");
                return false;
            }
            this.Saldo -= valorSaque;
            Console.WriteLine($"O Saldo atual da conta de {this.Nome} é {this.Saldo}");
            return true;
        }

        public void Depositar(double valorDeposito)
        {
            this.Saldo += valorDeposito;
            Console.WriteLine($"O Saldo atual da conta de {this.Nome} é {this.Saldo}");
        }

        public void Transferir(double valorTransferencia, Conta contaDestino)
        {
            if (this.Sacar(valorTransferencia))
            {
                contaDestino.Depositar(valorTransferencia);
            }
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += $"TipoDeConta: {this.TipoConta} |";
            retorno += $"Nome do Cliente: {this.Nome} |";
            retorno += $"Saldo Disponível: {this.Saldo} |";
            retorno += $"Crédito: {this.Credito}";
            return retorno;
        }

    }
}
