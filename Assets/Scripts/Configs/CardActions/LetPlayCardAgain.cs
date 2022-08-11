using GameLogic.Player;
using UnityEngine;

namespace GameLogic.Cards.CardActions
{
    [CreateAssetMenu(fileName = "LetPlayCardAgain", menuName = "Cards/LetPlayCardAgain", order = 1)]
    public class LetPlayCardAgain : CardAction
    {
        public override void DoAction(IPlayerModel subject, IPlayerModel target)
        {
            subject.LetToPlayCardAgain();
        }
    }
}