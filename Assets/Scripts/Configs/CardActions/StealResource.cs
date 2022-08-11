using System;
using GameLogic.Core;
using GameLogic.Player;
using UnityEngine;

namespace GameLogic.Cards.CardActions
{
    [CreateAssetMenu(fileName = "StealResource", menuName = "Cards/StealResource", order = 1)]
    public class StealResource : CardAction
    {
        [SerializeField] private ResourceType _type;
        [SerializeField] private int _resourceAmount;
        
        public override void DoAction(IPlayerModel subject, IPlayerModel target)
        {
            int stealAmount = Math.Min(_resourceAmount, target.GetResourceAmount(_type));
            target.ChangeResources(-stealAmount, _type);
            subject.ChangeResources(stealAmount / 2, _type);
        }
    }
}