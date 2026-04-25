using System;
using System.Collections.Generic;
using System.Text;

namespace Jogo
{
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
        public void ReceberDano(int dano)
        {
            Vida = Math.Max(0, Vida - dano);
            Console.WriteLine($"{Nome} recebeu {dano} de dano! Vida de {Nome}: {Vida}");
        }
        public void Atacar(Jogador alvo)
        {
            if (Vida <= 0) return;

            int dano = 15;
            Console.WriteLine($"{Nome} avança contra {alvo.Nome}!");
            alvo.ReceberDano(dano);
        }

    }
}
