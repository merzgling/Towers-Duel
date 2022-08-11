using GameLogic.Core;
using GameLogic.Player;
using UnityEngine;

namespace GameLogic.Cards.CardActions
{
    [CreateAssetMenu(fileName = "ChangeResource", menuName = "Cards/ChangeResource", order = 1)]
    public class ChangeResource : CardAction
    {
        [SerializeField] private ResourceType _type;
        [SerializeField] private int _resourceDelta; 
        
        public override void DoAction(IPlayerModel subject, IPlayerModel target)
        {
            if (_toYourself)
                subject.ChangeResources(_resourceDelta, _type);
            else
                target.ChangeResources(_resourceDelta, _type);
        }
    }
}