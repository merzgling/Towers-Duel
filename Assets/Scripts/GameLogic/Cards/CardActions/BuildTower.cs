using GameLogic.Player;
using UnityEngine;

namespace GameLogic.Cards.CardActions
{
    [CreateAssetMenu(fileName = "BuildTower", menuName = "Cards/BuildTower", order = 1)]
    public class BuildTower : CardAction
    {
        [SerializeField] private int buildAmount;
        
        public override void DoAction(IPlayerController subject, IPlayerController target)
        {
            subject.BuildTower(buildAmount);
        }
    }
}