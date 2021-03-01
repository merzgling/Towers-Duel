using System.Collections.Generic;
using GameLogic.Cards;
using GameLogic.Rules.GameStartRules;

namespace GameLogic.Player
{
    public class PlayerData
    {
        public int TowerHeight;
        public int WallHeight;
        public int UranusMines;
        public int EnergyMines;
        public int SlavesMines;
        public int Uranus;
        public int Energy;
        public int Slaves;

        public List<Card> Hand = new List<Card>();

        public List<Card> Deck = new List<Card>();

        public PlayerData(GameStartRule gameStartRule)
        {
            TowerHeight = gameStartRule.StartTowerHeight;
            WallHeight = gameStartRule.StartWallHeight;
            
            UranusMines = gameStartRule.StartUranusMines;
            EnergyMines = gameStartRule.StartEnergyMines;
            SlavesMines = gameStartRule.StartSlavesMines;
            
            Uranus = gameStartRule.StartUranus;
            Energy = gameStartRule.StartEnergy;
            Slaves = gameStartRule.StartSlaves;
        }
    }
}