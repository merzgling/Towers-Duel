using System;
using GameLogic.Player;
using UnityEngine;

namespace GameLogic.Cards.CardActions
{
    [CreateAssetMenu(fileName = "DealDamage", menuName = "Cards/DealDamage", order = 1)]
    public class DealDamage : CardAction
    {
        [SerializeField] private int DamageAmount; 
        
        public override void DoAction(IPlayerModel subject, IPlayerModel target)
        {
            target.TakeDamage(DamageAmount);
        }
    }
}