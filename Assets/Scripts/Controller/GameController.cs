using GameLogic.Cards;
using GameLogic.GameLoop;
using GameLogic.Player;
using GameLogic.Rules;
using GameView;
using UnityEngine;

namespace Controller
{
    public class GameController : MonoBehaviour
    {
        [SerializeField] private Deck _deck;
        [SerializeField] private GameRules _gameRules;

        [SerializeField] private PlayerView _playerView1;
        [SerializeField] private PlayerView _playerView2;

        private PlayerData[] _playersData;
        
        private IGame _game;

        private void Start()
        {
            _game = new Game(_deck, _gameRules);

            _playersData = _game.GetPlayersData();
            _playerView1.SetData(_playersData[0], 0, this);
            _playerView2.SetData(_playersData[1], 1, this);
        }

        public bool TryToPlayCard(Card card, int playerIndex)
        {
            bool result = _game.TryToPlayCard(card, playerIndex);
            Debug.Log($"Card {card.Name} try to played, result: {result}");
            return result;
        }
    }
}