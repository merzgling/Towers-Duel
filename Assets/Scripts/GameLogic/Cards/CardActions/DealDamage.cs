using System;
using GameLogic.Player;
using UnityEngine;

namespace GameLogic.Cards.CardActions
{
    [CreateAssetMenu(fileName = "DealDamage", menuName = "Cards/DealDamage", order = 1)]
    public class DealDamage : ScriptableObject, ICardAction
    {
        [SerializeField] private int DamageAmount; 
        
        public void DoAction(IPlayerController subject, IPlayerController target)
        {
            target.TakeDamage(DamageAmount);
        }
    }
}