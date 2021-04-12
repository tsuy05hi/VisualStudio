using System;
using gameFPS.Lib;

namespace gameFPS
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo = new HeadShot(new Jogador1(),
                                    new Jogador2() );
            jogo.IniciarJogo();
        }
    }

}
