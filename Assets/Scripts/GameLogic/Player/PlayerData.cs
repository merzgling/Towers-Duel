using System.Collections.Generic;
using GameLogic.Cards;

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

        public List<Card> Hand;

        public List<Card> Deck;
    }
}