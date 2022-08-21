using System.Collections;
using System.Collections.Generic;
using GameLogic.Cards;
using GameLogic.Core;
using UnityEngine;
using UnityEngine.UI;

public class CostView : MonoBehaviour
{
    [SerializeField] private Text _number;
    [SerializeField] private GameObject _energyGem;
    [SerializeField] private GameObject _uranusGem;
    [SerializeField] private GameObject _slavesGem;

    public void SetData(CardCost cardCost)
    {
        _energyGem.SetActive(false);
        _uranusGem.SetActive(false);
        _slavesGem.SetActive(false);
        
        _number.text = cardCost.ResourceAmount.ToString();
        if (cardCost.ResourceType == ResourceType.Energy)
            _energyGem.SetActive(true);
        if (cardCost.ResourceType == ResourceType.Uranus)
            _uranusGem.SetActive(true);
        if (cardCost.ResourceType == ResourceType.Slaves)
            _slavesGem.SetActive(true);
    }
}
