using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack
{
    public class Baraja
    {
        public Random rng = new Random();
        private Carta[] cartas;
        private int tope;

        public Baraja()
        {
            tope = 0;

            cartas = new Carta[52];

            // ♠♣♥♦
            for (int i = 0; i < cartas.Length; i++)
            {
                cartas[i] = new Carta(rng.Next(1, 14), "♠♣♥♦"[rng.Next(4)]);
            }

        }

        public void Mezclar()
        {
            tope = 0;
            Carta aux;
            int azar1, azar2;
            for (int i = 0; i < 300; i++)
            {
                azar1 = rng.Next(0, cartas.Length);
                azar2 = rng.Next(0, cartas.Length);
                aux = cartas[azar1];
                cartas[azar1] = cartas[azar2];
                cartas[azar2] = aux;
            }
        }

        public Carta LevantaCarta()
        {
            tope += 1;
            return cartas[tope - 1];
        }

        public void Imprimir()
        {
            for (int i = 0; i < cartas.Length; i++)
            {
                Console.Write("Carta "+i+": ");
                cartas[i].Dibuja();
                Console.WriteLine();
            }
        }
    }
}