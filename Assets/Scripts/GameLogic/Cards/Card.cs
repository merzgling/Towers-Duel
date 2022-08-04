using System.Collections.Generic;
using GameLogic.Cards.CardActions;
using GameLogic.Player;

namespace GameLogic.Cards
{
    public class Card
    {
        public string Name;
        public string Description;
        public CardCost CardCost;
        public List<CardAction> Actions;

        public Card(CardInfo card)
        {
            Name = card.Name;
            Description = card.Description;
            Actions = card.Actions;
            CardCost = card.CardCost;
        }
    }
}