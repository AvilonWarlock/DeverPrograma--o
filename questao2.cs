using System;
using System.Collections.Generic;

namespace questao2
{
    class Program
    {
        public static void QuantasVezesCadaPalavraAparece(string texto)
        {
            HashSet<string> ListaDasLetras = new HashSet<string>();
            foreach (var item in texto.Split(',', ' ', '.'))
            {
                if (!string.IsNullOrWhiteSpace(item)) ListaDasLetras.Add(item.Trim());
            }
            Console.WriteLine(ListaDasLetras.Count);
        }
    }
}
