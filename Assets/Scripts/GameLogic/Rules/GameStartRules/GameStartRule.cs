using UnityEditor;
using UnityEngine;

namespace GameLogic.Rules.GameStartRules
{
    [CreateAssetMenu(fileName = "GameStartRule", menuName = "Rules/GameStartRule", order = 1)]
    public class GameStartRule : ScriptableObject
    {
        public int StartTowerHeight;
        public int StartWallHeight;

        public int StartUranusMines;
        public int StartEnergyMines;
        public int StartSlavesMines;
        
        public int StartUranus;
        public int StartEnergy;
        public int StartSlaves;
        
        public int NumberOfCardsOnStart;
    }
}