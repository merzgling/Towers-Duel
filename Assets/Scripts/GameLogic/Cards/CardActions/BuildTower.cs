using GameLogic.Player;
using UnityEngine;

namespace GameLogic.Cards.CardActions
{
    [CreateAssetMenu(fileName = "BuildTower", menuName = "Cards/BuildTower", order = 1)]
    public class BuildTower : ScriptableObject, ICardAction
    {
        [SerializeField] private int buildAmount;
        
        public void DoAction(IPlayerController subject, IPlayerController target)
        {
            subject.BuildTower(buildAmount);
        }
    }
}