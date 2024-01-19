using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack
{
    public class Crupier {

        public Baraja baraja;
        List<Carta> manoCrupier;

        public Crupier() {
            baraja = new Baraja();
            manoCrupier = new List<Carta>();
        }
    
    }
}