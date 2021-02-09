using GameLogic.Player;
using UnityEngine;

namespace GameLogic.Rules.GameEndRules
{
    [CreateAssetMenu(fileName = "ResourceCollectEndRule", menuName = "Rules/ResourceCollectEndRule", order = 1)]
    public class ResourceCollectEndRule : ScriptableObject, IGameEndRule
    {
        [SerializeField] private int numberOfCollectedResource;
        
        public bool IsWinAchieved(PlayerData playerData)
        {
            return playerData.Energy >= numberOfCollectedResource ||
                   playerData.Uranus >= numberOfCollectedResource ||
                   playerData.Slaves >= numberOfCollectedResource;
        }

        public bool IsLoseAchieved(PlayerData playerData)
        {
            return false;
        }
    }
}