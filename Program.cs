namespace BlackJack
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Crupier crupier = new Crupier();
            Jugador jugador = new Jugador();

            jugador.pideCarta(crupier);

            Console.ReadKey();
            Console.Clear();


        }
    }
}