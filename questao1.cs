using System;
using System.Collections.Generic;

namespace questao1
{
    class Program
    {
        private static void QuantasVezesCadaPalavraAparece(string palavrasTotais)
        {
            throw new NotImplementedException();
        }

        public static void ContarPalavrasDiferentes(string texto)
        {
            HashSet<string> ListaDasLetras = new HashSet<string>();
            foreach (var item in texto.Split(',', ' ', '.'))
            {
                if (!string.IsNullOrWhiteSpace(item)) ListaDasLetras.Add(item.Trim());
                if (!string.IsNullOrWhiteSpace(item)) Console.WriteLine(item.Trim());
            }
        }
        static void Main(string[] args)
        {
            string PalavrasTotais = ("...Uma atividade livre, conscientemente tomada como “não-séria” e exterior à vida habitual, " +
                "mas ao mesmo tempo capaz de absorver o jogador de maneira intensa e total. É uma atividade desligada de todo e " +
                "qualquer interesse material, com a qual não se pode obter qualquer lucro, praticada dentro de limites espaciais e " +
                "temporais próprios, segundo uma certa ordem e certas regras. Promove a formação de grupos sociais com tendência a " +
                "rodearem-se de segredo e a sublinharem sua diferença em relação ao resto do mundo por meio de disfarces ou outros meios semelhantes.");


            ContarPalavrasDiferentes(PalavrasTotais);
            QuantasVezesCadaPalavraAparece(PalavrasTotais);


            Console.ReadKey();
        }
    }
}
