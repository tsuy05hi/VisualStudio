using gameFPS.Interface;

namespace gameFPS.Lib
{
    public class Jogador2 : iJogador
    {
        public readonly string _Nome;
        public Jogador2(string nome = "Ladrão")
        {
            _Nome = nome;
        }        
        public string Atira()
        {
            return $"{_Nome} está Atirando";
        }

        public string Corre()
        {
            return $"{_Nome} está Correndo";
        }

        public string Mira()
        {
            return $"{_Nome} está Mirando";
        }
    }
}