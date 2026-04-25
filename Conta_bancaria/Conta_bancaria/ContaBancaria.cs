using System;
using System.Collections.Generic;
using System.Text;

namespace Conta_bancaria
{
	public class ContaBancaria
	{
		private decimal _saldo;
		private List<string> _historico = new List<string>();

		public decimal Saldo
		{
			get { return _saldo; }
			set { _saldo = value; }
		}

		public ContaBancaria(decimal saldoInicial = 0m)
		{
			Saldo = saldoInicial < 0 ? 0m : saldoInicial;
			RegistrarAcao($"Abertura de conta com {Saldo:C2}");
		}

		private void RegistrarAcao(string mensagem)
		{
			_historico.Add($"{DateTime.Now:HH:mm:ss} - {mensagem} | Saldoatual{Saldo:C2}");
		}

		public bool Depositar(decimal quantia)
		{
			if (quantia <= 0)
			{
				RegistrarAcao($"Tentativa de depósito inválida: {quantia:C2}");
				return false;
			}
			Saldo += quantia;
			RegistrarAcao($"Depósito realizado: {quantia:C2}");
			return true;
		}

		public bool Sacar(decimal quantia)
		{
			if (quantia <= 0 || quantia > Saldo)
			{
				RegistrarAcao($"Tentativa de saque negada: {quantia:C2}");
				return false;
			}
			Saldo -= quantia;
			RegistrarAcao($"Saque realizado: {quantia:C2}");
			return true;
		}

		public void ExibirHistorico()
		{
			Console.WriteLine("\n---HISTÓRICO DA CONTA---");
			_historico.ForEach(Console.WriteLine);
		}
	}
}
