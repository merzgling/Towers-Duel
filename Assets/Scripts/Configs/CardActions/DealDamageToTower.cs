using System;
using GameLogic.Player;
using Unity.Mathematics;
using UnityEngine;

namespace GameLogic.Cards.CardActions
{
    [CreateAssetMenu(fileName = "DealDamageToTower", menuName = "Cards/DealDamageToTower", order = 1)]
    public class DealDamageToTower : CardAction
    {
        [SerializeField] private int _damageAmount;
        public override void DoAction(IPlayerModel subject, IPlayerModel target)
        {
            if (_toYourself)
                subject.TakeDamageToTower(_damageAmount);
            else
                target.TakeDamageToTower(_damageAmount);
        }
    }
}