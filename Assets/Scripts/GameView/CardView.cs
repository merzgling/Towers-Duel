using Controller;
using GameLogic.Cards;
using UnityEngine;
using UnityEngine.UI;

namespace GameView
{
    public class CardView : MonoBehaviour
    {
        private Card _card;
        private GameController _gameController;
        private int _playerIndex;
        
        [SerializeField] private Text _name;
        [SerializeField] private Text _cardCost;
        [SerializeField] private Text _description;

        public void SetData(Card card, int playerIndex, GameController gameController)
        {
            _card = card;
            _name.text = _card.Name;
            _cardCost.text = _card.CardCost.ResourceAmount.ToString();
            _description.text = _card.Description;
            _playerIndex = playerIndex;
            _gameController = gameController;
        }

        public void OnClick()
        {
            _gameController.TryToPlayCard(_card, _playerIndex);
        }
    }
}