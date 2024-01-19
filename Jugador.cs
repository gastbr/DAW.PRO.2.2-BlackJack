using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack
{
    public class Jugador
    {
        int puntos;
        List<Carta> mano;
        public Jugador()
        {
            mano = new List<Carta>();
        }

        public void pideCarta(Crupier c) {
            c.baraja.LevantaCarta();

            

        }
    }

}