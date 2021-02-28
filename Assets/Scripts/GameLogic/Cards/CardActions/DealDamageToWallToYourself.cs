using System;
using GameLogic.Player;
using UnityEngine;

namespace GameLogic.Cards.CardActions
{
    [CreateAssetMenu(fileName = "DealDamageToWallToYourself", menuName = "Cards/DealDamageToWallToYourself", order = 1)]
    public class DealDamageToWallToYourself : ScriptableObject, ICardAction
    {
        [SerializeField] private int DamageAmount;
        
        public void DoAction(IPlayerController subject, IPlayerController target)
        {
            subject.TakeDamageToWall(DamageAmount);
        }
    }
}