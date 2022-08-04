using System.Collections.Generic;
using GameLogic.Cards.CardActions;
using UnityEditor;
using UnityEngine;

namespace GameLogic.Cards
{
    [CreateAssetMenu(fileName = "Card", menuName = "Cards/Card", order = 1)]
    public class CardInfo : ScriptableObject
    {
        public string Name;
        public string Description;
        public CardCost CardCost;
        public List<CardAction> Actions;
    }
}