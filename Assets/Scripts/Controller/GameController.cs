using GameLogic.Cards;
using GameLogic.GameLoop;
using GameLogic.Rules;
using UnityEngine;

namespace Controller
{
    public class GameController : MonoBehaviour
    {
        [SerializeField] private Deck _deck;
        [SerializeField] private GameRules _gameRules;
        
        private IGame _game;

        private void Start()
        {
            _game = new Game(_deck, _gameRules);
        }
    }
}