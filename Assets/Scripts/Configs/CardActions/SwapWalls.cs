using GameLogic.Player;
using UnityEngine;

namespace GameLogic.Cards.CardActions
{
    [CreateAssetMenu(fileName = "SwapWalls", menuName = "Cards/SwapWalls", order = 1)]
    public class SwapWalls : CardAction
    {
        public override void DoAction(IPlayerModel subject, IPlayerModel target)
        {
            (subject.PlayerData.WallHeight, target.PlayerData.WallHeight) = (target.PlayerData.WallHeight, subject.PlayerData.WallHeight);
        }
    }
}