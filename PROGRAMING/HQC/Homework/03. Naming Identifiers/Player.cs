namespace Minesweeper
{
    public class Player
    {
        public Player()
        {
        }

        public Player(string name, int points)
        {
            this.Name = name;
            this.PlayerPoints = points;
        }

        public string Name { get; set; }

        public int PlayerPoints { get; set; }
    }
}