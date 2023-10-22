using MelonLoader;
using BTD_Mod_Helper;
using BloonProgression;
using BTD_Mod_Helper.Api.ModOptions;

[assembly: MelonInfo(typeof(BloonProgression.BloonProgression), ModHelperData.Name, ModHelperData.Version, ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]

namespace BloonProgression;

public class BloonProgression : BloonsTD6Mod
{
    public static readonly ModSettingDouble EasyCashMultiplier = new(1)
    {
        requiresRestart = true,
        description = "Cash Multiplier For The Easy Game Mode"
    };
    public static readonly ModSettingDouble MediumCashMultiplier = new(1.15)
    {
        requiresRestart = true,
        description = "Cash Multiplier For The Medium Game Mode"
    };
    public static readonly ModSettingDouble HardCashMultiplier = new(1.25)
    {
        requiresRestart = true,
        description = "Cash Multiplier For The Hard Game Mode"
    };
}