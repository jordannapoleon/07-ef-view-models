using LuckySpin.Models;
namespace LuckySpin.ViewModels
{
    public class PlayersChoice
    {
        public Player Player { get; set; }
        //TODO: Add  additional properties needed to pre-fill the PlayersChoice View.
        public List<Player> Players { get; set; }
        public List<Game> Games { get; set; }

    }
}