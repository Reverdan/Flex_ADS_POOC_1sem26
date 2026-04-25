using System;
using System.Collections.Generic;
using System.Text;

namespace Jogo
{
    public class Jogo
    {
        private Jogador? _jogador;
        public void Executar()
        {
            // Passo 1: Validar ambiente
            Console.WriteLine("=== RPG CONSOLE: INICIALIZANDO INTERFACE ===\n");
            _jogador = new Jogador("Guerreiro C#", 100);

            // Passo 7 e 8: Criar inimigos e gerenciar batalhas
            var listaInimigos = new List<Inimigo>
        {
            new Inimigo("Orc", 50, 100),
            new Inimigo("Dragão", 80, 500)
        };
            foreach (var inimigo in listaInimigos)
            {
                // Checklist: Segunda batalha só começa se jogador vivo
                if (_jogador.Vida > 0)
                {
                    Batalhar(_jogador, inimigo);
                }
            }
            ExibirResumoFinal();
        }
        // Passo 8: Lógica de Batalha
        private void Batalhar(Jogador jogador, Inimigo inimigo)
        {
            Console.WriteLine($"\n--- NOVA BATALHA: {jogador.Nome} vs {inimigo.Nome} ---");

            // Checklist: Termina quando alguém chega a 0
            while (jogador.Vida > 0 && inimigo.Vida > 0)
            {
                ExibirStatus(jogador, inimigo);

                jogador.Atacar(inimigo);

                if (inimigo.Vida > 0)
                {
                    inimigo.Atacar(jogador);
                }
                Console.WriteLine("\nPressione ENTER para o próximo turno...");
                Console.ReadLine();
            }
            if (jogador.Vida > 0)
            {
                Console.WriteLine($"\nVITÓRIA! {inimigo.Nome} foi derrotado.");
                // Checklist: Ganha pontos somente ao derrotar
                jogador.GanharPontos(inimigo.Recompensa);
            }
            else
            {
                Console.WriteLine($"\nDERROTA... {jogador.Nome} caiu em combate.");
            }
        }
        // Extensão: Separação de responsabilidades (Métodos de UI)
        private void ExibirStatus(Jogador j, Inimigo i)
        {
            Console.WriteLine($"\n[STATUS] {j.Nome}: {j.Vida} HP | {i.Nome}: {i.Vida} HP");
            Console.WriteLine(new string('-', 30));
        }
        private void ExibirResumoFinal()
        {
            Console.WriteLine("\n" + new string('=', 40));
            Console.WriteLine("FIM DE JOGO");
            Console.WriteLine($"Pontuação Final: {_jogador?.Pontos}");
            Console.WriteLine(new string('=', 40));
            Console.WriteLine("Pressione ENTER para fechar.");
            Console.ReadLine();
        }

    }
}
