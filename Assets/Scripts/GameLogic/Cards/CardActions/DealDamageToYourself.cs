using System;
using GameLogic.Player;
using UnityEngine;

namespace GameLogic.Cards.CardActions
{
    [CreateAssetMenu(fileName = "DealDamageToYourself", menuName = "Cards/DealDamageToYourself", order = 1)]
    public class DealDamageToYourself : CardAction
    {
        [SerializeField] private int DamageAmount;
        
        public override void DoAction(IPlayerController subject, IPlayerController target)
        {
            subject.TakeDamage(DamageAmount);
        }
    }
}