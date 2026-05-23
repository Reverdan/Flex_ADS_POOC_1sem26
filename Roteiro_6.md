# Roteiro 6 — Interfaces e Cálculos de Formas

## Parte A — Configuração
1. Criar projeto Console App.
2. Definir nome da solução/projeto.
3. Validar execução inicial.

## Parte B — Implementação

### 1) Interface `IForma`
- `double CalcularArea();`
- `double CalcularPerimetro();`

### 2) Classe `Retangulo : IForma`
- Propriedades: `Largura` e `Altura`.
- Construtor para inicialização.
- Implementar área e perímetro.

### 3) Classe `Circulo : IForma`
- Propriedade: `Raio`.
- Construtor para inicialização.
- Implementar área e perímetro usando `Math.PI`.

### 4) Aplicação principal
- Criar `List<IForma>`.
- Adicionar retângulo e círculo.
- Percorrer com `foreach` imprimindo área/perímetro.

---

## Parte C — Registro
No relatório, incluir:
- saída do console;
- explicação de onde está a interface e onde ocorre polimorfismo.

---

## Parte D — Extensões
- adicionar terceira forma;
- ler dados do usuário;
- validar entradas;
- formatar saída com casas decimais.

---

## Exemplo de implementação
```csharp
using System;
using System.Collections.Generic;

public interface IForma
{
    double CalcularArea();
    double CalcularPerimetro();
}

public class Retangulo : IForma
{
    public double Largura { get; set; }
    public double Altura { get; set; }

    public Retangulo(double largura, double altura)
    {
        Largura = largura;
        Altura = altura;
    }

    public double CalcularArea() => Largura * Altura;
    public double CalcularPerimetro() => 2 * (Largura + Altura);
}

public class Circulo : IForma
{
    public double Raio { get; set; }

    public Circulo(double raio) => Raio = raio;

    public double CalcularArea() => Math.PI * Math.Pow(Raio, 2);
    public double CalcularPerimetro() => 2 * Math.PI * Raio;
}

var formas = new List<IForma>
{
    new Retangulo(10, 5),
    new Circulo(3)
};

foreach (var forma in formas)
{
    Console.WriteLine($"Forma: {forma.GetType().Name}");
    Console.WriteLine($"Área: {forma.CalcularArea():F2}");
    Console.WriteLine($"Perímetro: {forma.CalcularPerimetro():F2}");
    Console.WriteLine(new string('-', 30));
}
```
