using System;
using GameLogic.Player;
using Unity.Mathematics;
using UnityEngine;

namespace GameLogic.Cards.CardActions
{
    [CreateAssetMenu(fileName = "DealDamageToTower", menuName = "Cards/DealDamageToTower", order = 1)]
    public class DealDamageToTower : ScriptableObject, ICardAction
    {
        [SerializeField] private int DamageAmount;
        public void DoAction(PlayerData subject, PlayerData target)
        {
            int damage = Math.Min(DamageAmount, target.TowerHeight);
            target.TowerHeight -= damage;
        }
    }
}