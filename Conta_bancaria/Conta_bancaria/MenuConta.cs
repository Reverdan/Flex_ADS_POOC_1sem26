using System;
using System.Collections.Generic;
using System.Text;

namespace Conta_bancaria
{
    public class MenuConta
    {
        private ContaBancaria _conta;

        public MenuConta(ContaBancaria conta)
        {
            _conta = conta;
        }

        public void Exibir()
        {
            string opcao = "";
            while(opcao != "0")
            {
                Console.WriteLine($"\nSaldo Atual: {_conta.Saldo:C2}");
                Console.WriteLine("1. Depositar | 2. Sacar | 3. Ver histórico | 0. Sair");
                Console.WriteLine("Escolha: ");
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        ProcessarOperacao("depósito", _conta.Depositar);
                        break;
                    case "2":
                        ProcessarOperacao("saque", _conta.Sacar);
                        break;
                    case "3":
                        _conta.ExibirHistorico();
                        break;
                }
            }
        }

        private void ProcessarOperacao(string tipo, Func<decimal, bool> operacao)
        {
            Console.Write($"Valor para {tipo}: ");
            if (decimal.TryParse(Console.ReadLine(), out decimal valor))
            {
                bool sucesso = operacao(valor);
                Console.WriteLine(sucesso ? "Operação realizada" :
                    "Operação recusada (valor inválido ou insuficiente).");
            }
        }
    }
}
