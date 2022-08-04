using GameLogic.Player;
using StaticFunctions;
using UnityEngine;

namespace Controller
{
    public class AIPlayerController : PlayerController
    {
        public AIPlayerController(PlayerData playerData, GameController gameController) : base(playerData, gameController) { }

        public void TakeAction()
        {
            bool shouldToPlayCard = true;
            int i = 0;
            while (shouldToPlayCard && i < 10)
            {
                shouldToPlayCard = !TryToPlayCard(_playerData.Hand.GetRandom());
            }
        }
    }
}