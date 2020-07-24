using GameTop.lib;
using GameTop.Interface;

namespace GameTOP
{
    public class JogoFODA
    {
        private readonly iJogador _Jogador1;
        private readonly iJogador _Jogador2;

        public JogoFODA(iJogador jogador1, iJogador jogador2)
        {
            _Jogador1 = jogador1;
            _Jogador2 = jogador2;
        }
        public void IniciarJogo(){

            //System.Console.WriteLine($"{_NomeJogador._Nome } deu um passe");
            System.Console.WriteLine(_Jogador1.Corre());
            System.Console.WriteLine(_Jogador1.Chuta());
            System.Console.WriteLine(_Jogador1.Passe());

            System.Console.WriteLine("\nPRÓXIMO JOGADOR \n");

            System.Console.WriteLine(_Jogador2.Corre());
            System.Console.WriteLine(_Jogador2.Chuta());
            System.Console.WriteLine(_Jogador2.Passe());
            
        }
    }
}