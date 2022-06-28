using GameLogic.Cards;
using GameLogic.Player;

namespace Controller
{
    public class PlayerController
    {
        private PlayerData _playerData;
        private GameController _gameController;

        public PlayerController(PlayerData playerData, GameController gameController)
        {
            _playerData = playerData;
            _gameController = gameController;
        }

        public bool TryToPlayCard(Card card)
        {
            return _gameController.TryToPlayCard(card, _playerData.PlayerIndex);
        }
    }
}