using System;
using GameLogic.Player;
using UnityEngine;

namespace GameLogic.Rules.GameEndRules
{
    [Serializable]
    [CreateAssetMenu(fileName = "ResourceCollectEndRule", menuName = "Rules/ResourceCollectEndRule", order = 1)]
    public class ResourceCollectEndRule : GameEndRule 
    {
        [SerializeField] private int numberOfCollectedResource;
        
        public override bool IsWinAchieved(PlayerData playerData)
        {
            return playerData.Energy >= numberOfCollectedResource ||
                   playerData.Uranus >= numberOfCollectedResource ||
                   playerData.Slaves >= numberOfCollectedResource;
        }

        public override bool IsLoseAchieved(PlayerData playerData)
        {
            return false;
        }
    }
}