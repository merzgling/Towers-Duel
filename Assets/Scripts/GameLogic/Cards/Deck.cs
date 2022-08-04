using System.Collections.Generic;
using StaticFunctions;

namespace GameLogic.Cards
{
    public class Deck
    {
        private DeckInfo _deckInfo;
        private List<Card> _cardsPool = new List<Card>();

        public Deck(DeckInfo deck)
        {
            _deckInfo = deck;
            ShuffleCardPool();
        }

        public Card DrawCard()
        {
            if (_cardsPool.Count == 0)
                ShuffleCardPool();

            Card result = _cardsPool.GetRandom();
            _cardsPool.Remove(result);
            return result;
        }

        private void ShuffleCardPool()
        {
            _cardsPool.Clear();
            foreach (var card in _deckInfo.Cards)
            {
                _cardsPool.Add(new Card(card));
            };
            
        }
    }
}