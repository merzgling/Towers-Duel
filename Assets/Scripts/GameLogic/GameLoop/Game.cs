using System;
using System.Collections.Generic;
using GameLogic.Cards;
using GameLogic.Player;
using GameLogic.Rules;

namespace GameLogic.GameLoop
{
    public class Game : IGame
    {
        private GameRules _gameRules;
        private List<IPlayerModel> _players = new List<IPlayerModel>();
        public int CurrentPlayer { get; private set; }

        public Action<GameResult> GameEnds { get; }

        private int _totalPlayer => _players.Count;
        
        public Game(Deck deck, GameRules gameRules)
        {
            _gameRules = gameRules;
            _players.Add(new PlayerModel(new PlayerData(gameRules.GameStartRule), deck));
            _players.Add(new PlayerModel(new PlayerData(gameRules.GameStartRule), deck));
            
            _players[0].TakeCard(_gameRules.GameStartRule.NumberOfCardsOnStart);
            _players[1].TakeCard(_gameRules.GameStartRule.NumberOfCardsOnStart);
        }

        private void EndTurn()
        {
            CurrentPlayer++;
            CurrentPlayer %= _totalPlayer;
            
            _players[CurrentPlayer].TakeCard(1); 
        }

        public bool TryToPlayCard(Card card, int playerIndex)
        {
            if (playerIndex != CurrentPlayer)
                return false;
            
            var target = _players[1 - playerIndex];
            
            bool turnValid = _players[playerIndex].PlayCard(card, target);

            if (turnValid)
            {
                EndTurn();

                CheckGameEnds();
            }
            
            return turnValid;
        }

        public PlayerData[] GetPlayersData()
        {
            return new []
            {
                _players[0].PlayerData,
                _players[1].PlayerData
            };
        }

        private void CheckGameEnds()
        {
            bool player0Won = _players[0].IsPlayerWin(_gameRules) || _players[1].IsPlayerLose(_gameRules);
            bool player1Win = _players[1].IsPlayerWin(_gameRules) || _players[0].IsPlayerLose(_gameRules);
            
            if (player0Won && player1Win)
                Draw();
            
            if (player0Won && ! player1Win)
                Win(0);
            
            if (player1Win && ! player0Won)
                Win(1);
        }

        private void Win(int playerIndex)
        {
            GameEnds?.Invoke(new GameResult()
            {
                WonPlayer = playerIndex,
            });
        }

        private void Draw()
        {
            GameEnds?.Invoke(new GameResult()
            {
                WonPlayer = -1,
            });
        }
    }
}