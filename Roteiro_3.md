# Roteiro 3 — Jogo de Batalha em POO

## Sequência recomendada
1. Criar projeto Console e validar com “Olá, mundo”.
2. Criar classe `Jogador` com propriedades e construtor.
3. Implementar `ReceberDano` no jogador.
4. Implementar `GanharPontos`.
5. Criar classe `Inimigo` com `ReceberDano`.
6. Implementar `Atacar` em `Jogador` e `Inimigo`.
7. Criar classe `Jogo` com método `Executar()`.
8. Implementar `Batalhar(...)` com laço `while`.
9. Conectar tudo no ponto de entrada (`Main`/top-level).
10. Revisar mensagens e legibilidade do console.

---

## Checklist de validação
- O código compila sem erros.
- `Main()` chama `Executar()` corretamente.
- `Batalhar(...)` termina quando alguém chega a `Vida == 0`.
- A vida nunca fica negativa.
- O jogador ganha pontos apenas ao derrotar o inimigo.
- A próxima batalha só inicia se o jogador estiver vivo.

---

## Extensões opcionais
- Adicionar terceiro inimigo.
- Implementar ataque crítico com chance aleatória.
- Incluir item de cura com uso limitado.
- Melhorar ritmo do jogo com resumo por turno.
- Separar responsabilidades em métodos menores.

---

## Exemplo de implementação
```csharp
using System;
using System.Collections.Generic;

var jogo = new Jogo();
jogo.Executar();

public class Jogador
{
    public string Nome { get; init; }
    public int Vida { get; private set; }
    public int Pontos { get; private set; }

    public Jogador(string nome, int vidaInicial)
    {
        Nome = nome;
        Vida = vidaInicial;
    }

    public void ReceberDano(int dano) => Vida = Math.Max(0, Vida - dano);
    public void GanharPontos(int pontos) => Pontos += pontos;

    public void Atacar(Inimigo alvo)
    {
        if (Vida <= 0) return;
        alvo.ReceberDano(20);
    }
}

public class Inimigo
{
    public string Nome { get; init; }
    public int Vida { get; private set; }
    public int Recompensa { get; init; }

    public Inimigo(string nome, int vida, int recompensa)
    {
        Nome = nome;
        Vida = vida;
        Recompensa = recompensa;
    }

    public void ReceberDano(int dano) => Vida = Math.Max(0, Vida - dano);

    public void Atacar(Jogador alvo)
    {
        if (Vida <= 0) return;
        alvo.ReceberDano(15);
    }
}

public class Jogo
{
    public void Executar()
    {
        var jogador = new Jogador("Guerreiro C#", 100);
        var inimigos = new List<Inimigo>
        {
            new Inimigo("Orc", 50, 100),
            new Inimigo("Dragão", 80, 500)
        };

        foreach (var inimigo in inimigos)
        {
            if (jogador.Vida > 0)
                Batalhar(jogador, inimigo);
        }

        Console.WriteLine($"Pontuação final: {jogador.Pontos}");
    }

    private void Batalhar(Jogador jogador, Inimigo inimigo)
    {
        while (jogador.Vida > 0 && inimigo.Vida > 0)
        {
            jogador.Atacar(inimigo);
            if (inimigo.Vida > 0)
                inimigo.Atacar(jogador);

            Console.WriteLine("Pressione ENTER para o próximo turno...");
            Console.ReadLine();
        }

        if (jogador.Vida > 0)
            jogador.GanharPontos(inimigo.Recompensa);
    }
}
```
