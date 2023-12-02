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
