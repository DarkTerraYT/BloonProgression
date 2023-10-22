using BTD_Mod_Helper.Api.Enums;
using BTD_Mod_Helper.Api.Scenarios;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models;
using Il2CppAssets.Scripts.Models.Difficulty;

namespace BloonProgression
{
    internal class BPE : ModGameMode
    {
        public override string Difficulty => DifficultyType.Easy;

        public override string BaseGameMode => GameModeType.None;

        public override void ModifyBaseGameModeModel(ModModel gameModeModel)
        {
            gameModeModel.UseRoundSet<BPER>();

            gameModeModel.SetStartingRound(1);
            gameModeModel.SetEndingRound(11);

            gameModeModel.SetAllCashMultiplier(BloonProgression.EasyCashMultiplier);
        }
    }
    internal class BPM : ModGameMode
    {
        public override string Difficulty => DifficultyType.Medium;

        public override string BaseGameMode => GameModeType.None;

        public override void ModifyBaseGameModeModel(ModModel gameModeModel)
        {
            gameModeModel.UseRoundSet<BPMR>();

            gameModeModel.SetStartingRound(1);
            gameModeModel.SetEndingRound(16);

            gameModeModel.SetAllCashMultiplier(BloonProgression.MediumCashMultiplier);
        }
    }
    internal class BPH : ModGameMode
    {
        public override string Difficulty => DifficultyType.Hard;

        public override string BaseGameMode => GameModeType.None;

        public override void ModifyBaseGameModeModel(ModModel gameModeModel)
        {
            gameModeModel.UseRoundSet<BPHR>();

            gameModeModel.SetStartingRound(1);
            gameModeModel.SetEndingRound(22);

            gameModeModel.SetAllCashMultiplier(BloonProgression.HardCashMultiplier);
        }
    }
}
