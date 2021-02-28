using System;
using GameLogic.Player;
using UnityEngine;

namespace GameLogic.Cards.CardActions
{
    [CreateAssetMenu(fileName = "DealDamageToYourself", menuName = "Cards/DealDamageToYourself", order = 1)]
    public class DealDamageToYourself : ScriptableObject, ICardAction
    {
        [SerializeField] private int DamageAmount;
        
        public void DoAction(IPlayerController subject, IPlayerController target)
        {
            subject.TakeDamage(DamageAmount);
        }
    }
}