using GameLogic.Core;
using GameLogic.Player;
using UnityEngine;

namespace GameLogic.Cards.CardActions.LogicPredicates
{
    [CreateAssetMenu(fileName = "WallCompareWithConstant", menuName = "Cards/LogicPredicates/WallCompareWithConstant", order = 1)]
    public class WallCompareWithConstant : LogicPredicate
    {
        [SerializeField] private PredictionType _predictionType;
        [SerializeField] private int _constantValue;
        [SerializeField] private bool _toYourself;
        
        public override bool Compare(IPlayerModel subject, IPlayerModel target)
        {
            if (_toYourself)
                return Compare(_predictionType, subject.PlayerData.WallHeight, _constantValue);
            else
                return Compare(_predictionType, target.PlayerData.WallHeight, _constantValue);
        }
    }
}