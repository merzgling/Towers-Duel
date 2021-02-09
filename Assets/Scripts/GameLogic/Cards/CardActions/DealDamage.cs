using System;
using GameLogic.Player;
using UnityEngine;

namespace GameLogic.Cards.CardActions
{
    [CreateAssetMenu(fileName = "DealDamage", menuName = "Cards/DealDamage", order = 1)]
    public class DealDamage : ScriptableObject, ICardAction
    {
        [SerializeField] private int DamageAmount; 
        
        public void DoAction(PlayerData subject, PlayerData target)
        {
            int damageToWall = Math.Min(DamageAmount, target.WallHeight);
            int damageToTower = Math.Min(DamageAmount - damageToWall, target.TowerHeight);

            target.WallHeight -= damageToWall;
            target.TowerHeight -= damageToTower;
        }
    }
}