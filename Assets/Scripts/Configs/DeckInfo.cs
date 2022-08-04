using System.Collections.Generic;
using UnityEngine;

namespace GameLogic.Cards
{
    [CreateAssetMenu(fileName = "Deck", menuName = "Cards/Deck", order = 1)]
    public class DeckInfo : ScriptableObject
    {
        public List<CardInfo> Cards;
    }
}