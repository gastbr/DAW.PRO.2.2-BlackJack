using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack
{
    public class Carta
    {
        public int numero;
        public char palo;
        public int valor;

        public Carta(int numero, char palo)
        {
            this.numero = numero;
            this.palo = palo;
            if (numero == 1)
            {
                valor = 14;
            }
            else
            {
                valor = numero;
            }
        }

        public void Dibuja()
        {
            // ♠♣♥♦
            if (numero == 1)
            {
                Console.Write($"A{palo}");
            }
            else if (numero == 11)
            {
                Console.Write($"J{palo}");
            }
            else if (numero == 12)
            {
                Console.Write($"Q{palo}");
            }
            else if (numero == 13)
            {
                Console.Write($"K{palo}");
            }
            else
            {
                Console.Write($"{numero}{palo}");
            }

            
        }
    }
}