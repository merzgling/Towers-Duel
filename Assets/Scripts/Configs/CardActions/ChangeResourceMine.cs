using GameLogic.Core;
using GameLogic.Player;
using UnityEngine;

namespace GameLogic.Cards.CardActions
{
    [CreateAssetMenu(fileName = "ChangeResourceMines", menuName = "Cards/ChangeResourceMines", order = 1)]
    public class ChangeResourceMine : CardAction
    {
        [SerializeField] private ResourceType _type;
        [SerializeField] private int _minesDelta; 
        
        public override void DoAction(IPlayerModel subject, IPlayerModel target)
        {
            if (_toYourself)
                subject.ChangeMines(_minesDelta, _type);
            else
                target.ChangeMines(_minesDelta, _type);
        }
    }
}