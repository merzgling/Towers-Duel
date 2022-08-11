using System;
using GameLogic.Player;
using UnityEngine;

namespace GameLogic.Cards.CardActions
{
    [CreateAssetMenu(fileName = "DealDamageToWall", menuName = "Cards/DealDamageToWall", order = 1)]
    public class DealDamageToWall : CardAction
    {
        [SerializeField] private int _damageAmount;
        public override void DoAction(IPlayerModel subject, IPlayerModel target)
        {
            if (_toYourself)
                subject.TakeDamageToWall(_damageAmount);
            else
                target.TakeDamageToWall(_damageAmount);
        }
    }
}