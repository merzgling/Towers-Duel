using System.Collections.Generic;
using GameLogic.Rules.GameEndRules;
using UnityEngine;

namespace GameLogic.Rules
{
    [CreateAssetMenu(fileName = "GameRules", menuName = "Rules/GameRules", order = 1)]
    public class GameRules : ScriptableObject
    {
        public List<IGameEndRule> GameEndRules;
    }
}