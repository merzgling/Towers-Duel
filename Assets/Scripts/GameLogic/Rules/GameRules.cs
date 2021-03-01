using System.Collections.Generic;
using GameLogic.Rules.GameEndRules;
using GameLogic.Rules.GameStartRules;
using UnityEngine;

namespace GameLogic.Rules
{
    [CreateAssetMenu(fileName = "GameRules", menuName = "Rules/GameRules", order = 1)]
    public class GameRules : ScriptableObject
    {
        public List<GameEndRule> GameEndRules;

        public GameStartRule GameStartRule;
    }
}