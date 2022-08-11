using GameLogic.Core;
using GameLogic.Player;
using UnityEngine;

namespace GameLogic.Cards.CardActions.LogicPredicates
{
    [CreateAssetMenu(fileName = "TowerCompare", menuName = "Cards/LogicPredicates/TowerCompare", order = 1)]
    public class TowerCompare : LogicPredicate
    {
        [SerializeField] private PredictionType _predictionType;
        
        public override bool Compare(IPlayerModel subject, IPlayerModel target)
        {
            return Compare(_predictionType, target.PlayerData.TowerHeight, subject.PlayerData.TowerHeight);
        }
    }
}