using GameLogic.Player;
using UnityEngine;

namespace GameLogic.Rules.GameEndRules
{
    [CreateAssetMenu(fileName = "TowerLostEndRule", menuName = "Rules/TowerLostEndRule", order = 1)]
    public class TowerLostEndRule : ScriptableObject, IGameEndRule
    {
        public bool IsWinAchieved(PlayerData playerData)
        {
            return false;
        }

        public bool IsLoseAchieved(PlayerData playerData)
        {
            return playerData.TowerHeight <= 0;
        }
    }
}