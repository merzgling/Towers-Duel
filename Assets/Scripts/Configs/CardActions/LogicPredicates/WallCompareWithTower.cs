using GameLogic.Core;
using GameLogic.Player;
using UnityEngine;

namespace GameLogic.Cards.CardActions.LogicPredicates
{
    [CreateAssetMenu(fileName = "WallCompareWithTower", menuName = "Cards/LogicPredicates/WallCompareWithTower", order = 1)]
    public class WallCompareWithTower : LogicPredicate
    {
        [SerializeField] private PredictionType _predictionType;
        
        public override bool Compare(IPlayerModel subject, IPlayerModel target)
        {
            return Compare(_predictionType, target.PlayerData.WallHeight, subject.PlayerData.TowerHeight);
        }
    }
}