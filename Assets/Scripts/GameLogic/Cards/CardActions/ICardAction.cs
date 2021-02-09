using GameLogic.Player;

namespace GameLogic.Cards.CardActions
{
    public interface ICardAction
    {
        void DoAction(PlayerData subject, PlayerData target);
    }
}