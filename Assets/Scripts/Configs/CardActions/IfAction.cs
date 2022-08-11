using System.Collections.Generic;
using GameLogic.Cards.CardActions.LogicPredicates;
using GameLogic.Player;
using UnityEngine;

namespace GameLogic.Cards.CardActions
{
    [CreateAssetMenu(fileName = "IfAction", menuName = "Cards/IfAction", order = 1)]
    public class IfAction : CardAction
    {
        [SerializeField] private CardAction _ifTrueAction;
        [SerializeField] private CardAction _ifFalseAction;
        [SerializeField] private LogicPredicate _predicate;

        public override void DoAction(IPlayerModel subject, IPlayerModel target)
        {
            if (_predicate.Compare(subject, target))
            {
                if (_ifTrueAction)
                    _ifTrueAction.DoAction(subject, target);
            }
            else
                if (_ifFalseAction)
                    _ifFalseAction.DoAction(subject, target);
        }
    }
}