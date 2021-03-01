using System;
using GameLogic.Player;
using UnityEngine;

namespace GameLogic.Cards.CardActions
{
    [Serializable]
    public abstract class CardAction : ScriptableObject
    {
        public abstract void DoAction(IPlayerController subject, IPlayerController target);
    }
}