using System.Collections.Generic;
using GameLogic.Core;
using GameLogic.Player;
using UnityEngine;

namespace GameLogic.Cards.CardActions
{
    [CreateAssetMenu(fileName = "ListAction", menuName = "Cards/ListAction", order = 1)]
    public class ListAction : CardAction
    {
        [SerializeField] private List<CardAction> Actions;

        public override void DoAction(IPlayerModel subject, IPlayerModel target)
        {
            foreach (var action in Actions)
            {
                action.DoAction(subject, target);
            }
        }
    }
}