using gameFPS.Interface;

namespace gameFPS
{
    public class HeadShot
    {
        private readonly iJogador _jogador1;
        private readonly iJogador _jogador2;
        public HeadShot(iJogador jogador1, iJogador jogador2)
        {
            _jogador1 = jogador1;
            _jogador2 = jogador2;
        }
        public void IniciarJogo()
        {
            System.Console.WriteLine(_jogador1.Corre());
            System.Console.WriteLine(_jogador1.Mira());
            System.Console.WriteLine(_jogador1.Atira());

            System.Console.WriteLine(_jogador2.Corre());
            System.Console.WriteLine(_jogador2.Mira());
            System.Console.WriteLine(_jogador2.Atira());

        }
    }
}