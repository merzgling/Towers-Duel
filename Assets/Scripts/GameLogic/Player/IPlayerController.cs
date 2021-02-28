using System.Collections.Generic;
using GameLogic.Cards;
using GameLogic.GameLoop;
using GameLogic.Rules;

namespace GameLogic.Player
{
    public interface IPlayerController
    {
        bool IsPlayerWin(GameRules gameRules);

        bool IsPlayerLose(GameRules gameRules);
        
        void TakeDamage(int amount);
        
        void TakeDamageToWall(int amount);
        
        void TakeDamageToTower(int amount);

        void BuildWall(int amount);

        void BuildTower(int amount);

        void TakeCard(int amount);

        void DiscardCard(int amount);

        bool PlayCard(Card card, IPlayerController target);
    }
}