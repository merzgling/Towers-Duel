﻿using GameLogic.Cards;
using GameLogic.GameLoop;
using GameLogic.Player;
using GameLogic.Rules;
using GameView;
using UnityEngine;

namespace Controller
{
    public class GameController : MonoBehaviour
    {
        [SerializeField] private DeckInfo deckInfo;
        [SerializeField] private GameRules _gameRules;

        [SerializeField] private PlayerView _playerView1;
        [SerializeField] private PlayerView _playerView2;

        private PlayerData[] _playersData;
        
        private IGame _game;
        private Deck _deck;
        private AIPlayerController _aiPlayerController;

        private void Start()
        {
            _deck = new Deck(deckInfo);
            _game = new Game(_deck, _gameRules);

            _playersData = _game.GetPlayersData();
            _aiPlayerController = new AIPlayerController(_playersData[1], this);
        }

        public bool TryToPlayCard(Card card, int playerIndex)
        {
            bool result = _game.TryToPlayCard(card, playerIndex);
            Debug.Log($"Card {card.Name} try to played {playerIndex} player, result: {result}");
            return result;
        }

        void Update()
        {
            if (_game.CurrentPlayer == 1)
                _aiPlayerController.TakeAction();
            _playerView1.SetData(_playersData[0], 0, this);
            _playerView2.SetData(_playersData[1], 1, this);
        }
    }
}