using GameLogic.Core;
using GameLogic.Player;
using UnityEngine;

namespace GameLogic.Cards.CardActions.LogicPredicates
{
    [CreateAssetMenu(fileName = "ResourceCompare", menuName = "Cards/LogicPredicates/ResourceCompare", order = 1)]
    public class ResourceCompare : LogicPredicate
    {
        [SerializeField] private bool _compareMines;
        [SerializeField] private ResourceType _resourceType;
        [SerializeField] private PredictionType _predictionType;
        
        public override bool Compare(IPlayerModel subject, IPlayerModel target)
        {
            if (_compareMines)
                return Compare(_predictionType, target.GetResourceMinesAmount(_resourceType), subject.GetResourceMinesAmount(_resourceType));
            else
                return Compare(_predictionType, target.GetResourceAmount(_resourceType), subject.GetResourceAmount(_resourceType));
        }
    }
}