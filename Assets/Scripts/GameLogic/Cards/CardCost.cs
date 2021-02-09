using System;
using GameLogic.Core;

namespace GameLogic.Cards
{
    [Serializable]
    public class CardCost
    {
        public ResourceType ResourceType;
        public int RessurceAmount;
    }
}