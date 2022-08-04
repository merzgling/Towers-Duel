using System.Collections.Generic;
using GameLogic.Cards;
using GameLogic.GameLoop;
using GameLogic.Rules;

namespace GameLogic.Player
{
    public interface IPlayerModel
    {
        bool IsPlayerWin(GameRules gameRules);

        bool IsPlayerLose(GameRules gameRules);
        
        void TakeDamage(int amount);
        
        void TakeDamageToWall(int amount);
        
        void TakeDamageToTower(int amount);

        void BuildWall(int amount);

        void BuildTower(int amount);

        void DrawCard(int amount);

        void DiscardCard(int amount);

        bool PlayCard(Card card, IPlayerModel target);
        
        PlayerData PlayerData { get; }
    }
}