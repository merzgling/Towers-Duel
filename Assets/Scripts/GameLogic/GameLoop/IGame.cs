using System;
using GameLogic.Cards;

namespace GameLogic.GameLoop
{
    public interface IGame
    {
        bool TryToPlayCard(Card card, int playerIndex);
        
        int CurrentPlayer { get; }
        
        Action<GameResult> GameEnds { get; }
    }
}