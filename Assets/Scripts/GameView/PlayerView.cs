using Controller;
using GameLogic.Player;
using UnityEngine;
using UnityEngine.UI;

namespace GameView
{
    public class PlayerView : MonoBehaviour
    {
        [SerializeField] private Text _uranusMinesText;
        [SerializeField] private Text _energyMinesText;
        [SerializeField] private Text _slavesMinesText;
        
        [SerializeField] private Text _uranusText;
        [SerializeField] private Text _energyText;
        [SerializeField] private Text _slavesText;

        [SerializeField] private Text _towerHeightText;
        [SerializeField] private Text _wallHeightText;

        [SerializeField] private HandView _handView;

        public void SetData(PlayerData playerData, int playerIndex, GameController gameController)
        {
            _uranusMinesText.text = playerData.UranusMines.ToString();
            _energyMinesText.text = playerData.EnergyMines.ToString();
            _slavesMinesText.text = playerData.SlavesMines.ToString();
            
            _uranusText.text = playerData.Uranus.ToString();
            _energyText.text = playerData.Energy.ToString();
            _slavesText.text = playerData.Slaves.ToString();

            _towerHeightText.text = playerData.TowerHeight.ToString();
            _wallHeightText.text = playerData.WallHeight.ToString();

            if (_handView)
                _handView.SetData(playerData.Hand, playerIndex, gameController);
        }
    }
}