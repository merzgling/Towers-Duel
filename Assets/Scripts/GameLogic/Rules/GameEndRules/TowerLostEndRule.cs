using GameLogic.Player;
using UnityEngine;

namespace GameLogic.Rules.GameEndRules
{
    [CreateAssetMenu(fileName = "TowerLostEndRule", menuName = "Rules/TowerLostEndRule", order = 1)]
    public class TowerLostEndRule : GameEndRule
    {
        public override bool IsWinAchieved(PlayerData playerData)
        {
            return false;
        }

        public override bool IsLoseAchieved(PlayerData playerData)
        {
            return playerData.TowerHeight <= 0;
        }
    }
}