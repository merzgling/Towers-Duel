using GameLogic.Player;
using UnityEngine;

namespace GameLogic.Rules.GameEndRules
{
    [CreateAssetMenu(fileName = "TowerHeightEndRule", menuName = "Rules/TowerHeightEndRule", order = 1)]
    public class TowerHeightEndRule : ScriptableObject, IGameEndRule
    {
        [SerializeField] private int MaxHeight;
        
        public bool IsWinAchieved(PlayerData playerData)
        {
            return playerData.TowerHeight >= MaxHeight;
        }

        public bool IsLoseAchieved(PlayerData playerData)
        {
            return false;
        }
    }
}