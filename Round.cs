namespace Csharp_Pokemon
{
    public class Round
    {
        Player winningPlayer = null;
        Player player1;
        Player player2;

        public Round(Player player1, Player player2)
        {
            this.player1 = player1;
            this.player2 = player2;
        }


        public void StartTurn()
        {
            player1.DisplayPokemons();

            int idx;
            do
            {
                Console.WriteLine("Select Pokemon:");
                idx = Console.Read() - '0';
                Console.Clear();
            } while (!(idx>=0 && idx<player1.pokemons.Length));
            
            player1.SetActivePokemon(idx);

            this.winningPlayer = player1;
        }

        public void Play()
        {
            while (this.winningPlayer==null)
            {
                StartTurn();
            }

            Console.WriteLine(winningPlayer.name + " has won!");
        }
    }
}
