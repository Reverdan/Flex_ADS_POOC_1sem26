# Roteiro 2 — Condicionais e Laços

## Etapa 1 — Mensagens iniciais
1. Imprima um título no console.
2. Imprima uma linha em branco para organizar a saída.

```csharp
Console.WriteLine("=== DEMONSTRAÇÃO DE CONDICIONAIS E LAÇOS ===");
Console.WriteLine();
```

---

## Etapa 2 — Identificadores *case-sensitive*
1. Declare variáveis com nomes diferentes apenas por maiúsculas/minúsculas.
2. Atribua valores distintos.
3. Imprima os valores.

```csharp
int aluno = 10;
int Aluno = 20;

Console.WriteLine($"aluno: {aluno}");
Console.WriteLine($"Aluno: {Aluno}");
```

---

## Etapa 3 — Classificação por nota com `if / else if / else`
1. Declare a variável `nota`.
2. Imprima a nota.
3. Classifique por faixa.
4. Teste com `40`, `60`, `75` e `95`.

```csharp
int nota = 75;
Console.WriteLine($"Nota do aluno: {nota}");

if (nota < 50)
    Console.WriteLine("Desempenho: Insatisfatório");
else if (nota < 70)
    Console.WriteLine("Desempenho: Regular");
else if (nota < 90)
    Console.WriteLine("Desempenho: Bom");
else
    Console.WriteLine("Desempenho: Excelente");
```

---

## Etapa 4 — Comando com `switch`
1. Declare `char comando`.
2. Exiba o comando escolhido.
3. Trate os casos `A`, `D`, `F` e `default`.
4. Teste com `A`, `D`, `F` e `X`.

```csharp
char comando = 'A';
Console.WriteLine($"Comando selecionado: {comando}");

switch (comando)
{
    case 'A':
        Console.WriteLine("Ação: Abrir arquivo.");
        break;
    case 'D':
        Console.WriteLine("Ação: Deletar registro.");
        break;
    case 'F':
        Console.WriteLine("Ação: Fechar aplicação.");
        break;
    default:
        Console.WriteLine("Ação: Comando desconhecido ou inválido.");
        break;
}
```

---

## Etapa 5 — Contagem com `for`
1. Informe que iniciará a contagem.
2. Conte de `1` a `5`.
3. Exiba cada valor.

```csharp
Console.WriteLine("Iniciando a contagem de 1 até 5:");

for (int i = 1; i <= 5; i++)
{
    Console.WriteLine($"Contagem atual: {i}");
}
```

---

## Etapa 6 — Contagem regressiva com `while`
1. Inicialize `contador` (ex.: `3`).
2. Execute enquanto `contador > 0`.
3. Imprima e decremente.
4. Mostre mensagem de encerramento.

```csharp
int contador = 3;

while (contador > 0)
{
    Console.WriteLine($"Valor atual: {contador}");
    contador--;
}

Console.WriteLine("Fim da contagem!");
```

---

## Etapa 7 — Pausa final no console
1. Solicite ENTER.
2. Use `Console.ReadLine()` para manter a janela aberta.

```csharp
Console.Write("Pressione [ENTER] para sair...");
Console.ReadLine();
```

---

## Extensões sugeridas
- Ler nota com `TryParse`.
- Ler comando e converter para maiúscula.
- Organizar em classe com métodos separados.
- Criar menu com repetição para executar cada parte sem reiniciar.
