using GameLogic.Player;

namespace GameLogic.Rules.GameEndRules
{
    public interface IGameEndRule
    {
        bool IsWinAchieved(PlayerData playerData);

        bool IsLoseAchieved(PlayerData playerData);
    }
}