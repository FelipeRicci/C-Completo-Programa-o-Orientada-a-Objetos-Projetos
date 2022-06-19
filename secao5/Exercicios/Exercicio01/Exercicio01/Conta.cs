using System.Globalization;

namespace Exercicio01
{
    class Conta
    {
        public int NumeroConta { get; private set; }
        public string Nome { get; set; }
        public double Deposito { get; private set; }

        public Conta(int numeroConta, string nome)
        {
            NumeroConta = numeroConta;
            Nome = nome;
        }

        public Conta(int numeroConta, string nome, double deposito) : this(numeroConta, nome)
        {
            Deposito = deposito;
        }

        public void Depositar(double valor)
        {
            Deposito += valor;
        }

        public void Saque(double valor)
        {
            Deposito -= valor + 5.0;
        }

        public override string ToString()
        {
            return $"Conta {NumeroConta}, Titular: {Nome}, Saldo: {Deposito.ToString("F2", CultureInfo.InvariantCulture)}\n";
        }

    }
}