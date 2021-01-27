using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador2 : iJogador
    {
        public string Chuta()
        {
            return "Marta está chutando \n";
        }

        public string Corre()
        {
            return "Marta está correndo \n";
        }

        public string Passe()
        {
            return "Marta está passando \n";
        }
    }
}