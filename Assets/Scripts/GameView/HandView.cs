using System.Collections.Generic;
using Controller;
using GameLogic.Cards;
using UnityEngine;

namespace GameView
{
    public class HandView : MonoBehaviour
    {
        [SerializeField] private GameObject _cardPrefab;

        private Dictionary<Card, CardView> _cardViews = new Dictionary<Card, CardView>();

        public void SetData(List<Card> hand, int playerIndex, GameController gameController)
        {
            foreach (var card in hand)
            {
                if (!_cardViews.ContainsKey(card))
                {
                    CardView cardView = Instantiate(_cardPrefab).GetComponent<CardView>();
                    cardView.transform.parent = transform;
                    cardView.transform.localScale = new Vector3(1, 1, 1);
                    cardView.SetData(card, playerIndex, gameController);
                    _cardViews.Add(card, cardView);
                }
            }

            List<Card> cardsToRemove = new List<Card>();
            foreach (var cardView in _cardViews)
                if (!hand.Contains(cardView.Key))
                    cardsToRemove.Add(cardView.Key);
            
            foreach (var card in cardsToRemove)
                _cardViews.Remove(card);
        }
    }
}