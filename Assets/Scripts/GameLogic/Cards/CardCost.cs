using System;
using GameLogic.Core;

namespace GameLogic.Cards
{
    [Serializable]
    public class CardCost
    {
        public ResourceType ResourceType;
        public int ResourceAmount;

        public CardCost(CardCost instance)
        {
            ResourceType = instance.ResourceType;
            ResourceAmount = instance.ResourceAmount;
        }
    }
}