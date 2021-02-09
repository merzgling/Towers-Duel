using System.Collections.Generic;
using GameLogic.Cards.CardActions;
using UnityEditor;
using UnityEngine;

namespace GameLogic.Cards
{
    [CreateAssetMenu(fileName = "Card", menuName = "Cards/Card", order = 1)]
    public class Card : ScriptableObject
    {
        public CardCost CardCost;

        public List<ICardAction> Actions;
    }
}