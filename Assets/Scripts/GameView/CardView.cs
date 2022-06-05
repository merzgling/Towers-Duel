using GameLogic.Cards;
using UnityEngine;
using UnityEngine.UI;

namespace GameView
{
    public class CardView : MonoBehaviour
    {
        private Card _card;
        
        [SerializeField] private Text _name;
        [SerializeField] private Text _cardCost;
        [SerializeField] private Text _description;

        public void SetData(Card card)
        {
            _card = card;
            _name.text = card.Name;
            _cardCost.text = _card.CardCost.ResourceAmount.ToString();
            _description.text = _card.Description;
        }
    }
}