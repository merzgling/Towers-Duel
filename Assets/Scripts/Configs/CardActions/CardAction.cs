using System;
using GameLogic.Player;
using UnityEngine;

namespace GameLogic.Cards.CardActions
{
    [Serializable]
    public abstract class CardAction : ScriptableObject
    {
        [SerializeField] protected bool _toYourself;
        public abstract void DoAction(IPlayerModel subject, IPlayerModel target);
    }
}