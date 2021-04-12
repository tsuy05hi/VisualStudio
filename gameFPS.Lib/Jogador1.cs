using gameFPS.Interface;

namespace gameFPS.Lib
{
    public class Jogador1: iJogador
    {
        public readonly string _Nome;
        public Jogador1(string nome = "Policial")
        {
            _Nome = nome;
        }
        //Correr
        public string Corre()
        {
            return $"{_Nome} está correndo";
        }
        //Mirar
        public string Mira()
        {
            return $"{_Nome} está mirando";
        }
        //Atirar
        public string Atira()
        {
            return $"{_Nome} está atirando";
        }
        
    }
}