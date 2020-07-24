using GameTop.Interface;
namespace GameTop.lib
{
    public  class Jogador : iJogador
    {
        public readonly string _Nome;
        public Jogador(string nome)
        {
            _Nome = nome;
        }

        public string Chuta()
        {
            return $"{_Nome} está chutando";
        }

        public string Corre()
        {
            return $"{_Nome} está correndo";
        }

        public string  Passe()
        {
            return $"{_Nome} está pasando";
        }
    }
}