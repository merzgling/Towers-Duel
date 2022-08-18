using GameLogic.Core;
using GameLogic.Player;
using UnityEngine;

namespace GameLogic.Cards.CardActions
{
    [CreateAssetMenu(fileName = "MakesResourceEqual", menuName = "Cards/MakesResourceEqual", order = 1)]
    public class MakesResourceEqual : CardAction
    {
        [SerializeField] private ResourceType _type;
        [SerializeField] private bool _isMine;
        
        public override void DoAction(IPlayerModel subject, IPlayerModel target)
        {
            if (_toYourself)
            {
                if (_isMine)
                {
                    subject.ChangeMines(target.GetResourceMinesAmount(_type) - subject.GetResourceMinesAmount(_type), _type);
                }
                else
                {
                    subject.ChangeResources(target.GetResourceAmount(_type) - subject.GetResourceAmount(_type), _type);
                }
            }
            else
            {
                if (_isMine)
                {
                    target.ChangeMines(subject.GetResourceMinesAmount(_type) - target.GetResourceMinesAmount(_type), _type);
                }
                else
                {
                    target.ChangeResources(subject.GetResourceAmount(_type) - target.GetResourceAmount(_type), _type);
                }
            }
        }
    }
}