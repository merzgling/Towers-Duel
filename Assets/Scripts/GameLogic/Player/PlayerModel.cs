using System;
using System.Collections.Generic;
using GameLogic.Cards;
using GameLogic.Core;
using GameLogic.Rules;
using StaticFunctions;
namespace GameLogic.Player
{
    public class PlayerModel : IPlayerModel
    {
        private PlayerData _playerData;
        
        public PlayerData PlayerData => _playerData;

        public PlayerModel(PlayerData playerData, Deck deck)
        {
            _playerData = playerData;
            _playerData.Deck = deck;
        }

        public bool IsPlayerWin(GameRules gameRules)
        {
            bool result = false;

            foreach (var gameEndRule in gameRules.GameEndRules)
            {
                result |= gameEndRule.IsWinAchieved(_playerData);
            }

            return result;
        }

        public bool IsPlayerLose(GameRules gameRules)
        {
            bool result = false;

            foreach (var gameEndRule in gameRules.GameEndRules)
            {
                result |= gameEndRule.IsLoseAchieved(_playerData);
            }

            return result;
        }

        public void TakeDamage(int amount)
        {
            int damageToWall = Math.Min(amount, _playerData.WallHeight);
            int damageToTower = Math.Min(amount - damageToWall, _playerData.TowerHeight);

            _playerData.WallHeight -= damageToWall;
            _playerData.TowerHeight -= damageToTower;
        }

        public void TakeDamageToWall(int amount)
        {
            int damage = Math.Min(amount, _playerData.WallHeight);
            _playerData.WallHeight -= damage;
        }

        public void TakeDamageToTower(int amount)
        {
            int damage = Math.Min(amount, _playerData.TowerHeight);
            _playerData.TowerHeight -= damage;
        }

        public void BuildWall(int amount)
        {
            _playerData.WallHeight += amount;
        }

        public void BuildTower(int amount)
        {
            _playerData.TowerHeight += amount;
        }

        public void DrawCard(int amount)
        {
            while (amount > 0)
            {
                DrawCard(_playerData.Deck.DrawCard());
                amount--;
            }
        }

        public void DiscardCard(int amount)
        {
            while (amount > 0 && _playerData.Hand.Count > 0)
            {
                DiscardCard(_playerData.Hand.GetRandom());
                amount--;
            }
        }

        public bool PlayCard(Card card, IPlayerModel target)
        {
            if (_playerData.Hand.Contains(card) && HaveEnoughResources(card.CardCost))
            {
                PayCardCost(card.CardCost);
                DiscardCard(card);
                foreach (var action in card.Actions)  
                {
                    action.DoAction(this, target);
                }

                return true;
            }

            return false;
        }

        private void DrawCard(Card card)
        {
            _playerData.Hand.Add(_playerData.Deck.DrawCard());
        }

        private void DiscardCard(Card card)
        {
            _playerData.Hand.Remove(card);
        }

        private bool HaveEnoughResources(CardCost cost)
        {
            switch (cost.ResourceType)
            {
                case ResourceType.Uranus :
                    return _playerData.Uranus >= cost.ResourceAmount;
                case ResourceType.Energy :
                    return _playerData.Energy >= cost.ResourceAmount;
                case ResourceType.Slaves :
                    return _playerData.Slaves >= cost.ResourceAmount;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private void PayCardCost(CardCost cost)
        {
            switch (cost.ResourceType)
            {
                case ResourceType.Uranus :
                    _playerData.Uranus -= cost.ResourceAmount;
                    break;
                case ResourceType.Energy :
                    _playerData.Energy -= cost.ResourceAmount;
                    break;
                case ResourceType.Slaves :
                    _playerData.Slaves -= cost.ResourceAmount;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}