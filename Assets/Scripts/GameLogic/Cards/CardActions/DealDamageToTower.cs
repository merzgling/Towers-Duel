using System;
using GameLogic.Player;
using Unity.Mathematics;
using UnityEngine;

namespace GameLogic.Cards.CardActions
{
    [CreateAssetMenu(fileName = "DealDamageToTower", menuName = "Cards/DealDamageToTower", order = 1)]
    public class DealDamageToTower : CardAction
    {
        [SerializeField] private int DamageAmount;
        public override void DoAction(IPlayerController subject, IPlayerController target)
        {
            target.TakeDamageToTower(DamageAmount);
        }
    }
}