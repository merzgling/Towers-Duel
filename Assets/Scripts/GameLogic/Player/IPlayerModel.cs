using System.Collections.Generic;
using GameLogic.Cards;
using GameLogic.Core;
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

        void ChangeMines(int delta, ResourceType type);

        void ChangeResources(int delta, ResourceType type);

        void DrawCard(int amount);

        void DiscardCard(int amount);

        void LetToPlayCardAgain();

        void ForbidToPlayCardAgain();

        bool PlayCard(Card card, IPlayerModel target);

        bool CanPlayCardAgain();

        int GetResourceAmount(ResourceType type);

        int GetResourceMinesAmount(ResourceType type);

        void GetIncome();
        
        PlayerData PlayerData { get; }
    }
}