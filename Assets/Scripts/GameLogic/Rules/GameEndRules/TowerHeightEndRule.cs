using GameLogic.Player;
using UnityEngine;

namespace GameLogic.Rules.GameEndRules
{
    [CreateAssetMenu(fileName = "TowerHeightEndRule", menuName = "Rules/TowerHeightEndRule", order = 1)]
    public class TowerHeightEndRule : GameEndRule
    {
        [SerializeField] private int MaxHeight;
        
        public override bool IsWinAchieved(PlayerData playerData)
        {
            return playerData.TowerHeight >= MaxHeight;
        }

        public override bool IsLoseAchieved(PlayerData playerData)
        {
            return false;
        }
    }
}