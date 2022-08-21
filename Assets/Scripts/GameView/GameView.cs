using Controller;
using GameLogic.Player;
using UnityEngine;

namespace GameView
{
    public class GameView : MonoBehaviour
    {
        [SerializeField] private PlayerView _playerView1;
        [SerializeField] private PlayerView _playerView2;
        [SerializeField] private VisualEffectsProvider _effectsProvider;

        void Start()
        {
            _effectsProvider = new VisualEffectsProvider();
        }

        void Update()
        {
            
        }
        
        public void SetData(PlayerData player0, PlayerData player1, GameController gameController)
        {
            _playerView1.SetData(player0, 0, gameController);
            _playerView2.SetData(player1, 1, gameController);
        }
    }
}