# Roteiro 8 — Polimorfismo, Tipo Estático e Casting

## Parte A — Preparação
1. Criar projeto Console App.
2. Executar para validar ambiente.
3. Identificar ponto de entrada do programa.

## Parte B — Classe base `Animal`
1. Criar propriedade `Nome` (`string`, `get; set;`).
2. Criar método `Comer()`.
3. Criar método `virtual FazerSom()`.

## Parte C — Classe derivada `Cachorro`
1. Herdar de `Animal`.
2. Implementar `AbanarRabo()`.
3. Sobrescrever `FazerSom()`.

## Parte D — `animal1` como `Animal`
1. Criar `Animal animal1 = new Animal();`
2. Definir `animal1.Nome`.
3. Chamar `animal1.FazerSom()`.

## Parte E — `animal2` declarado como `Animal`, instanciado como `Cachorro`
1. Criar `Animal animal2 = new Cachorro();`
2. Definir `animal2.Nome`.
3. Chamar `animal2.FazerSom()` e observar override.

## Parte F — Entendendo erro de compilação
- `animal2.AbanarRabo()` não compila porque o tipo estático é `Animal`.

## Parte G — Casting para acessar método específico
- Fazer cast para `Cachorro` e chamar `AbanarRabo()`.

## Parte H — Método disponível na base
- `animal2.Comer()` funciona sem cast porque existe em `Animal`.

---

## Desafios
Escolha ao menos dois:
- usar `is` antes do cast;
- usar `as` e validar `null`;
- adicionar nova classe derivada (ex.: `Gato`);
- demonstrar polimorfismo com `List<Animal>`.

---

## Exemplo de implementação
```csharp
using System;
using System.Collections.Generic;

public class Animal
{
    public string Nome { get; set; } = "Animal";

    public void Comer() => Console.WriteLine($"{Nome} está comendo...");

    public virtual void FazerSom() => Console.WriteLine("Som genérico.");
}

public class Cachorro : Animal
{
    public void AbanarRabo() => Console.WriteLine($"{Nome} abanou o rabo!");

    public override void FazerSom() => Console.WriteLine($"{Nome} diz: Au Au!");
}

public class Gato : Animal
{
    public override void FazerSom() => Console.WriteLine($"{Nome} diz: Miau!");
}

Animal animal1 = new Animal { Nome = "Criatura" };
animal1.FazerSom();

Animal animal2 = new Cachorro { Nome = "Rex" };
animal2.FazerSom();
// animal2.AbanarRabo(); // Não compila.

((Cachorro)animal2).AbanarRabo();

if (animal2 is Cachorro cao)
    cao.AbanarRabo();

Animal animal3 = new Gato { Nome = "Luna" };

List<Animal> animais = new() { animal1, animal2, animal3 };
foreach (var animal in animais)
    animal.FazerSom();
```
