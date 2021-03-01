using GameLogic.Player;
using UnityEngine;

namespace GameLogic.Cards.CardActions
{
    [CreateAssetMenu(fileName = "BuildWall", menuName = "Cards/BuildWall", order = 1)]
    public class BuildWall : CardAction
    {
        [SerializeField] private int buildAmount;
        
        public override void DoAction(IPlayerController subject, IPlayerController target)
        {
            subject.BuildWall(buildAmount);
        }
    }
}