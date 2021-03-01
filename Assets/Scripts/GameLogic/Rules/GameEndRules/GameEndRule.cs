using System;
using GameLogic.Player;
using UnityEngine;

namespace GameLogic.Rules.GameEndRules
{
    [Serializable]
    public abstract class GameEndRule : ScriptableObject
    {
        public abstract bool IsWinAchieved(PlayerData playerData);

        public abstract bool IsLoseAchieved(PlayerData playerData);
    }
}