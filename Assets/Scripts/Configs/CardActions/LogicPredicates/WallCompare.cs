using GameLogic.Core;
using GameLogic.Player;
using UnityEngine;

namespace GameLogic.Cards.CardActions.LogicPredicates
{
    [CreateAssetMenu(fileName = "WallCompare", menuName = "Cards/LogicPredicates/WallCompare", order = 1)]
    public class WallCompare : LogicPredicate
    {
        [SerializeField] private PredictionType _predictionType;
        
        public override bool Compare(IPlayerModel subject, IPlayerModel target)
        {
            return Compare(_predictionType, target.PlayerData.WallHeight, subject.PlayerData.WallHeight);
        }
    }
}