# Roteiro 7 — Herança e Sobrescrita

## Parte A — Preparar o projeto
1. Criar projeto Console App em C#.
2. Validar compilação/execução inicial.
3. Identificar o arquivo principal (`Program.cs` ou top-level statements).

## Parte B — Classe base `Animal`
1. Criar classe `Animal`.
2. Propriedade `Nome` (`string`, com `get; set;`).
3. Método `Comer()` imprimindo mensagem com `Nome`.
4. Método `virtual FazerSom()` com som genérico.

## Parte C — Classe derivada `Cachorro`
1. Criar classe `Cachorro : Animal`.
2. Implementar método `AbanarRabo()`.
3. Sobrescrever `FazerSom()` com `override`.

## Parte D — Testes no programa principal
1. Criar objeto `Cachorro`.
2. Definir `Nome`.
3. Chamar, nesta ordem:
   - `Comer()`;
   - `AbanarRabo()`;
   - `FazerSom()`.

---

## Resultados esperados
- `Comer()` usa o nome do objeto.
- `AbanarRabo()` usa o nome do objeto.
- `FazerSom()` executa o som sobrescrito do cachorro.

---

## Desafios de aprimoramento
Escolha ao menos dois:
- criar classe `Gato` com método próprio;
- demonstrar polimorfismo com `List<Animal>`;
- validar `Nome` (evitar nulo/vazio);
- melhorar legibilidade do console.

---

## Exemplo de implementação
```csharp
using System;
using System.Collections.Generic;

public class Animal
{
    public string Nome { get; set; } = "Animal";

    public void Comer() => Console.WriteLine($"{Nome} está comendo...");

    public virtual void FazerSom() => Console.WriteLine($"{Nome} faz um som genérico.");
}

public class Cachorro : Animal
{
    public void AbanarRabo() => Console.WriteLine($"{Nome} está abanando o rabo!");

    public override void FazerSom() => Console.WriteLine($"{Nome} diz: Au Au!");
}

public class Gato : Animal
{
    public override void FazerSom() => Console.WriteLine($"{Nome} diz: Miau!");
}

Cachorro cachorro = new() { Nome = "Rex" };
cachorro.Comer();
cachorro.AbanarRabo();
cachorro.FazerSom();

List<Animal> animais = new() { cachorro, new Gato { Nome = "Luna" } };
foreach (var animal in animais)
    animal.FazerSom();
```
