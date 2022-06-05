using System.Collections.Generic;
using GameLogic.Cards.CardActions;
using UnityEditor;
using UnityEngine;

namespace GameLogic.Cards
{
    [CreateAssetMenu(fileName = "Card", menuName = "Cards/Card", order = 1)]
    public class Card : ScriptableObject
    {
        public string Name;
        public string Description;
        public CardCost CardCost;
        public List<CardAction> Actions;

        public Card Clone()
        {
            Card result = ScriptableObject.CreateInstance<Card>();
            result.Name = Name;
            result.Description = Description;
            result.Actions = new List<CardAction>(Actions);
            result.CardCost = new CardCost(CardCost);

            return result;
        }
    }
}