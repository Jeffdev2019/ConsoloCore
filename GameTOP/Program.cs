using System;
using GameTop.lib;

namespace GameTOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo = new JogoFODA(new Jogador("Jefferson"), new Jogador1("Júnior"));
            jogo.IniciarJogo();
        }
    }
}


