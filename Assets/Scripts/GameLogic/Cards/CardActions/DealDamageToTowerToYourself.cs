using System;
using GameLogic.Player;
using UnityEngine;

namespace GameLogic.Cards.CardActions
{
    [CreateAssetMenu(fileName = "DealDamageToTowerToYourself", menuName = "Cards/DealDamageToTowerToYourself",
        order = 1)]
    public class DealDamageToTowerToYourself : CardAction
    {
        [SerializeField] private int DamageAmount;

        public override void DoAction(IPlayerController subject, IPlayerController target)
        {
            subject.TakeDamageToTower(DamageAmount);
        }
    }
}