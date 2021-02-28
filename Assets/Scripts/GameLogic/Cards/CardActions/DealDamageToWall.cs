using System;
using GameLogic.Player;
using UnityEngine;

namespace GameLogic.Cards.CardActions
{
    [CreateAssetMenu(fileName = "DealDamageToWall", menuName = "Cards/DealDamageToWall", order = 1)]
    public class DealDamageToWall : ScriptableObject, ICardAction
    {
        [SerializeField] private int DamageAmount;
        public void DoAction(IPlayerController subject, IPlayerController target)
        {
            target.TakeDamageToWall(DamageAmount);
        }
    }
}