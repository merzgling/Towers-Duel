using GameLogic.Player;
using UnityEngine;

namespace GameLogic.Cards.CardActions
{
    [CreateAssetMenu(fileName = "BuildWall", menuName = "Cards/BuildWall", order = 1)]
    public class BuildWall : ScriptableObject, ICardAction
    {
        [SerializeField] private int buildAmount;
        
        public void DoAction(IPlayerController subject, IPlayerController target)
        {
            subject.BuildWall(buildAmount);
        }
    }
}