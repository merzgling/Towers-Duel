using System;
using GameLogic.Player;
using UnityEngine;

namespace GameLogic.Cards.CardActions
{
    [CreateAssetMenu(fileName = "DealDamageToWall", menuName = "Cards/DealDamageToWall", order = 1)]
    public class DealDamageToWall : CardAction
    {
        [SerializeField] private int DamageAmount;
        public override void DoAction(IPlayerModel subject, IPlayerModel target)
        {
            target.TakeDamageToWall(DamageAmount);
        }
    }
}