# Roteiro 1 — Fundamentos de C# Moderno

## Objetivo
Praticar recursos modernos da linguagem C# em 8 etapas progressivas.

## Etapa 1 — Primeira saída no console
1. No `Program.cs`, imprima uma mensagem de boas-vindas.
2. Execute com `F5` ou `Ctrl + F5`.

**Checkpoint:** o console deve exibir uma frase simples.

```csharp
Console.WriteLine("Olá, mundo! Este é o meu primeiro programa em C#.");
```

---

## Etapa 2 — Tipos, `var` e interpolação
1. Declare um `int` para o ano.
2. Declare uma variável de texto com `var`.
3. Use interpolação de string (`$"..."`).

**Checkpoint:** exibir nome e ano no console.

```csharp
int anoAtual = 2026;
var nomeDesenvolvedor = "Gemini";
Console.WriteLine($"Olá! Eu sou o {nomeDesenvolvedor} e estamos no ano de {anoAtual}.");
```

---

## Etapa 3 — Nullabilidade, `??` e `??=`
1. Declare `string?` com `null`.
2. Use `??` para valor padrão.
3. Use `??=` para atribuir apenas se estiver nulo.

**Checkpoint:** primeiro valor padrão, depois valor atribuído.

```csharp
string? nomeUsuario = null;
string exibir = nomeUsuario ?? "Convidado";
Console.WriteLine($"Status atual: {exibir}");

nomeUsuario ??= "C# Developer";
Console.WriteLine($"Nome após atribuição: {nomeUsuario}");
```

---

## Etapa 4 — `switch` expressão com pattern matching
1. Declare um `object?`.
2. Use `switch` expressão para gerar uma descrição.
3. Trate `null`, `int` com `when`, `string` e caso padrão (`_`).

```csharp
object? entrada = 150;

string descricao = entrada switch
{
    null => "O valor é nulo.",
    int n when n > 100 => $"É um número inteiro alto: {n}.",
    int n => $"É um número inteiro comum: {n}.",
    string s => $"É um texto com {s.Length} caracteres.",
    _ => "Tipo de dado desconhecido."
};

Console.WriteLine(descricao);
```

---

## Etapa 5 — Função local `static` com expression-bodied member
1. Crie uma função local `static` retornando `decimal`.
2. Use parâmetro opcional de taxa.
3. Imprima o resultado com formatação monetária.

```csharp
static decimal CalcularPrecoFinal(decimal preco, decimal taxa = 0.12m)
    => preco + (preco * taxa);

decimal valorProduto = 100.00m;
Console.WriteLine($"Preço com taxa padrão (12%): {CalcularPrecoFinal(valorProduto):C}");
Console.WriteLine($"Preço com taxa de 20%: {CalcularPrecoFinal(valorProduto, 0.20m):C}");
```

---

## Etapa 6 — `record` e `with`
1. Crie um `record Produto`.
2. Instancie `p1`.
3. Gere `p2` com `with`, alterando apenas o preço.

```csharp
public record Produto(int Id, string Nome, decimal Preco);

var p1 = new Produto(1, "Notebook Gamer", 4500.00m);
var p2 = p1 with { Preco = 4200.00m };

Console.WriteLine($"Produto Original: {p1}");
Console.WriteLine($"Produto com Desconto: {p2}");
```

---

## Etapa 7 — Propriedade com validação e token contextual `field`
1. Crie a classe `Config` com propriedade `Tema`.
2. No `set`, valide `null` com `ArgumentNullException`.
3. Atribua usando `field`.

```csharp
public class Config
{
    public string Tema
    {
        get => field ?? "Padrão";
        set
        {
            if (value is null)
                throw new ArgumentNullException(nameof(value), "O tema não pode ser nulo!");

            field = value;
        }
    }
}
```

---

## Etapa 8 — Atribuição condicional com `?.` no destino
1. Crie a classe `Cliente` com `Total`.
2. Use `cliente?.Total += ...`.
3. Imprima o resultado com segurança.

```csharp
public class Cliente
{
    public decimal Total { get; set; }
}

Cliente? cliente = new Cliente { Total = 100.00m };
cliente?.Total += 50.00m;
Console.WriteLine($"Total do cliente: {cliente?.Total}");
```

---

## Resumo
Neste roteiro você praticou:
- top-level statements;
- `var` e interpolação;
- nullabilidade (`?`, `??`, `??=`);
- pattern matching;
- funções locais e expression-bodied members;
- `record` e `with`;
- validação em propriedades;
- atribuição condicional segura.
