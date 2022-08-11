using GameLogic.Player;
using UnityEngine;

namespace GameLogic.Cards.CardActions
{
    [CreateAssetMenu(fileName = "BuildTower", menuName = "Cards/BuildTower", order = 1)]
    public class BuildTower : CardAction
    {
        [SerializeField] private int _buildAmount;
        
        public override void DoAction(IPlayerModel subject, IPlayerModel target)
        {
            subject.BuildTower(_buildAmount);
        }
    }
}