# Roteiro 4 — Conta Bancária com Encapsulamento

## Passo a passo

### 1) Preparar o projeto
1. Criar projeto Console.
2. Confirmar compilação e execução inicial.

### 2) Criar classe e campo
1. Criar classe `ContaBancaria`.
2. Declarar campo `private decimal _saldo`.

### 3) Criar propriedade `Saldo`
1. Expor leitura com `get`.
2. Restringir escrita com `private set`.

### 4) Criar construtor com parâmetro opcional
1. Receber `saldoInicial = 0m`.
2. Inicializar saldo.

### 5) Implementar `Depositar`
1. Retornar `bool`.
2. Aceitar apenas `quantia > 0`.

### 6) Implementar `Sacar`
1. Retornar `bool`.
2. Validar `quantia > 0`.
3. Validar `quantia <= saldo`.

### 7) Testar no `Main`
1. Criar conta com saldo inicial.
2. Testar operações válidas e inválidas.
3. Imprimir valor tentado, sucesso e saldo após cada operação.

---

## Checklist de validação
- Código compila sem erros.
- `Saldo` não pode ser alterado diretamente de fora da classe.
- Depósito não positivo é rejeitado.
- Saque não positivo é rejeitado.
- Saque acima do saldo é rejeitado.
- Saldo atualiza corretamente nos casos válidos.

---

## Extensões opcionais
- `Transferir(ContaBancaria destino, decimal quantia)`.
- Histórico de operações.
- Bloqueio de saldo inicial negativo.
- Menu no console com opções de operação.

---

## Exemplo de implementação
```csharp
using System;

var conta = new ContaBancaria(100m);

Console.WriteLine($"Saldo inicial: {conta.Saldo:C2}");
Console.WriteLine($"Depósito 50: {conta.Depositar(50m)} | Saldo: {conta.Saldo:C2}");
Console.WriteLine($"Depósito 0: {conta.Depositar(0m)} | Saldo: {conta.Saldo:C2}");
Console.WriteLine($"Saque 30: {conta.Sacar(30m)} | Saldo: {conta.Saldo:C2}");
Console.WriteLine($"Saque 500: {conta.Sacar(500m)} | Saldo: {conta.Saldo:C2}");
Console.WriteLine($"Saque -10: {conta.Sacar(-10m)} | Saldo: {conta.Saldo:C2}");

public class ContaBancaria
{
    private decimal _saldo;

    public decimal Saldo
    {
        get => _saldo;
        private set => _saldo = value;
    }

    public ContaBancaria(decimal saldoInicial = 0m)
    {
        Saldo = saldoInicial < 0 ? 0m : saldoInicial;
    }

    public bool Depositar(decimal quantia)
    {
        if (quantia <= 0) return false;
        Saldo += quantia;
        return true;
    }

    public bool Sacar(decimal quantia)
    {
        if (quantia <= 0 || quantia > Saldo) return false;
        Saldo -= quantia;
        return true;
    }
}
```
