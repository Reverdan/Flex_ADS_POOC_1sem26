# Roteiro 5 — Abstração e Polimorfismo com Animais

## Parte A — Configuração do projeto
1. Criar projeto Console App.
2. Definir nome da solução e do projeto.
3. Validar compilação e execução inicial.

## Parte B — Implementação

### 1) Classe abstrata `Animal`
- Classe deve ser `abstract`.
- Propriedade pública `Nome` (`string`).
- Construtor com parâmetro `nome`.
- Método abstrato `EmitirSom()`.

### 2) Subclasse `Cachorro`
- Herdar de `Animal`.
- Repassar `nome` para `base(nome)`.
- Implementar `EmitirSom()` com som de cachorro.

### 3) Subclasse `Gato`
- Herdar de `Animal`.
- Repassar `nome` para `base(nome)`.
- Implementar `EmitirSom()` com som de gato.

### 4) Teste no programa principal
- Declarar variáveis do tipo `Animal` com instâncias concretas.
- Chamar `EmitirSom()` em cada objeto.

---

## Parte C — Registro do resultado
No relatório, inclua:
- saída do console;
- explicação curta demonstrando o polimorfismo.

---

## Parte D — Extensões
Escolha pelo menos uma:
- adicionar terceiro animal;
- usar `List<Animal>` com laço;
- ler nomes com `Console.ReadLine()`;
- validar entrada de nome.

---

## Exemplo de implementação
```csharp
using System;
using System.Collections.Generic;

public abstract class Animal
{
    public string Nome { get; set; }

    protected Animal(string nome) => Nome = nome;

    public abstract void EmitirSom();
}

public class Cachorro : Animal
{
    public Cachorro(string nome) : base(nome) { }

    public override void EmitirSom() => Console.WriteLine($"[Cachorro] {Nome}: Au Au!");
}

public class Gato : Animal
{
    public Gato(string nome) : base(nome) { }

    public override void EmitirSom() => Console.WriteLine($"[Gato] {Nome}: Miau!");
}

var animais = new List<Animal>
{
    new Cachorro("Rex"),
    new Gato("Luna")
};

foreach (var animal in animais)
    animal.EmitirSom();
```
