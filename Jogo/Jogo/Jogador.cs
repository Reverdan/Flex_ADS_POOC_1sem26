using System;
using System.Collections.Generic;
using System.Text;

namespace Jogo
{
    public class Jogador
    {
        public string Nome { get; init; }
        public int Vida { get; private set; }
        public int Pontos { get; private set; }
        private Random _random = new Random();
        public Jogador(string nome, int vidaInicial)
        {
            Nome = nome;
            Vida = vidaInicial;
            Pontos = 0;
        }
        // Passo 3 e Checklist: Vida nunca fica negativa
        public void ReceberDano(int dano)
        {
            Vida = Math.Max(0, Vida - dano);
            Console.WriteLine($"{Nome} recebeu {dano} de dano! Vida restante: {Vida}");
        }
        // Passo 4: Ganhar Pontos
        public void GanharPontos(int quantidade)
        {
            Pontos += quantidade;
            Console.WriteLine($"{Nome} ganhou {quantidade} pontos! Total: {Pontos}");
        }
        // Passo 6: Implementar Atacar com Extensão (Crítico)
        public void Atacar(Inimigo alvo)
        {
            if (Vida <= 0) return;
            int danoBase = 20;
            bool eCritico = _random.Next(1, 101) <= 20; // 20% de chance
            int danoFinal = eCritico ? danoBase * 2 : danoBase;
            if (eCritico) Console.WriteLine("!!! ATAQUE CRÍTICO !!!");

            Console.WriteLine($"{Nome} ataca {alvo.Nome}!");
            alvo.ReceberDano(danoFinal);
        }

    }
}
