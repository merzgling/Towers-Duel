using GameLogic.Player;

namespace GameLogic.Cards.CardActions
{
    public interface ICardAction
    {
        void DoAction(IPlayerController subject, IPlayerController target);
    }
}