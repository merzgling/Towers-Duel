using System;
using GameLogic.Core;
using GameLogic.Player;
using UnityEngine;

namespace GameLogic.Cards.CardActions.LogicPredicates
{
    [Serializable]
    public abstract class LogicPredicate : ScriptableObject
    {
        public abstract bool Compare(IPlayerModel subject, IPlayerModel target);

        protected bool Compare(PredictionType predictionType, int arg1, int arg2)
        {
            if (predictionType == PredictionType.More)
                return arg1 > arg2;
            if (predictionType == PredictionType.Less)
                return arg1 < arg2;
            if (predictionType == PredictionType.Equal)
                return arg1 == arg2;
            if (predictionType == PredictionType.MoreEqual)
                return arg1 >= arg2;
            if (predictionType == PredictionType.LessEqual)
                return arg1 <= arg2;
            return false;
        }
    }
}