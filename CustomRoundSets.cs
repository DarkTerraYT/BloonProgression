using BTD_Mod_Helper.Api.Bloons;
using BTD_Mod_Helper.Api.Enums;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Rounds;
using Extension;

namespace BloonProgression
{
    internal class BPER : ModRoundSet
    {
        public override string BaseRoundSet => RoundSetType.Empty;

        public override string Icon => "BPE";

        public override int DefinedRounds => 11;

        public override void ModifyRoundModels(RoundModel roundModel, int round)
        {
            if(round == 1)
            {
                roundModel.AddBloonGroup(Ext.GetBloon("Red").id, 25);
            }
            if (round == 2)
            {
                roundModel.AddBloonGroup(Ext.GetBloon("Blue").id, 25);
            }
            if (round == 3)
            {
                roundModel.AddBloonGroup(Ext.GetBloon("Green").id, 25);
            }
            if (round == 4)
            {
                roundModel.AddBloonGroup(Ext.GetBloon("Yellow").id, 25);
            }
            if (round == 5)
            {
                roundModel.AddBloonGroup(Ext.GetBloon("Pink").id, 25);
            }
            if (round == 6)
            {
                roundModel.AddBloonGroup(Ext.GetBloon("White").id, 12);
                roundModel.AddBloonGroup(Ext.GetBloon("Black").id, 13);
            }
            if (round == 7)
            {
                roundModel.AddBloonGroup(Ext.GetBloon("Purple").id, 25);
            }
            if (round == 8)
            {
                roundModel.AddBloonGroup(Ext.GetBloon("Zebra").id, 25);
            }
            if (round == 9)
            {
                roundModel.AddBloonGroup(Ext.GetBloon("Rainbow").id, 25);
            }
            if (round == 10)
            {
                roundModel.AddBloonGroup(Ext.GetBloon("Ceramic").id, 25);
            }
        }
    }
    internal class BPMR : ModRoundSet
    {
        public override string BaseRoundSet => RoundSetType.Empty;

        public override string Icon => "BPM";

        public override int DefinedRounds => 16;

        public override void ModifyRoundModels(RoundModel roundModel, int round)
        {
            if (round == 1)
            {
                roundModel.AddBloonGroup(Ext.GetBloon("Red").id, 30);
            }
            if (round == 2)
            {
                roundModel.AddBloonGroup(Ext.GetBloon("Blue").id, 30);
            }
            if (round == 3)
            {
                roundModel.AddBloonGroup(Ext.GetBloon("Green").id, 30);
            }
            if (round == 4)
            {
                roundModel.AddBloonGroup(Ext.GetBloon("Yellow").id, 30);
            }
            if (round == 5)
            {
                roundModel.AddBloonGroup(Ext.GetBloon("Pink").id, 30);
            }
            if (round == 6)
            {
                roundModel.AddBloonGroup(Ext.GetBloon("White").id, 15);
                roundModel.AddBloonGroup(Ext.GetBloon("Black").id, 15);
            }
            if (round == 7)
            {
                roundModel.AddBloonGroup(Ext.GetBloon("Purple").id, 30);
            }
            if (round == 8)
            {
                roundModel.AddBloonGroup(Ext.GetBloon("Zebra").id, 30);
            }
            if (round == 9)
            {
                roundModel.AddBloonGroup(Ext.GetBloon("Lead").id, 30);
            }
            if (round == 10)
            {
                roundModel.AddBloonGroup(Ext.GetBloon("Rainbow").id, 30);
            }
            if (round == 11)
            {
                roundModel.AddBloonGroup(Ext.GetBloon("Ceramic").id, 30);
            }
            if (round == 12)
            {
                roundModel.AddBloonGroup(Ext.GetBloon("Moab").id, 30);
            }
            if (round == 13)
            {
                roundModel.AddBloonGroup(Ext.GetBloon("Bfb").id, 30);
            }
            if (round == 14)
            {
                roundModel.AddBloonGroup(Ext.GetBloon("MoabFortified").id, 30);
            }
            if (round == 15)
            {
                roundModel.AddBloonGroup(Ext.GetBloon("Zomg").id, 30);
            }
        }
    }
    internal class BPHR : ModRoundSet
    {
        public override string BaseRoundSet => RoundSetType.Empty;

        public override string Icon => "BPH";

        public override int DefinedRounds => 22;

        public override void ModifyRoundModels(RoundModel roundModel, int round)
        {
            if (round == 1)
            {
                roundModel.AddBloonGroup(Ext.GetBloon("Red").id, 50);
            }
            if (round == 2)
            {
                roundModel.AddBloonGroup(Ext.GetBloon("Blue").id, 50);
            }
            if (round == 3)
            {
                roundModel.AddBloonGroup(Ext.GetBloon("Green").id, 50);
            }
            if (round == 4)
            {
                roundModel.AddBloonGroup(Ext.GetBloon("Yellow").id, 50);
            }
            if (round == 5)
            {
                roundModel.AddBloonGroup(Ext.GetBloon("Pink").id, 50);
            }
            if (round == 6)
            {
                roundModel.AddBloonGroup(Ext.GetBloon("White").id, 25);
                roundModel.AddBloonGroup(Ext.GetBloon("Black").id, 25);
            }
            if (round == 7)
            {
                roundModel.AddBloonGroup(Ext.GetBloon("Purple").id, 50);
            }
            if (round == 8)
            {
                roundModel.AddBloonGroup(Ext.GetBloon("Zebra").id, 50);
            }
            if (round == 9)
            {
                roundModel.AddBloonGroup(Ext.GetBloon("Lead").id, 50);
            }
            if (round == 10)
            {
                roundModel.AddBloonGroup(Ext.GetBloon("Rainbow").id, 50);
            }
            if (round == 11)
            {
                roundModel.AddBloonGroup(Ext.GetBloon("Ceramic").id, 50);
            }
            if (round == 12)
            {
                roundModel.AddBloonGroup(Ext.GetBloon("Moab").id, 50);
            }
            if (round == 13)
            {
                roundModel.AddBloonGroup(Ext.GetBloon("Bfb").id, 50);
            }
            if (round == 14)
            {
                roundModel.AddBloonGroup(Ext.GetBloon("MoabFortified").id, 50);
            }
            if (round == 15)
            {
                roundModel.AddBloonGroup(Ext.GetBloon("Zomg").id, 50);
            }
            if (round == 16)
            {
                roundModel.AddBloonGroup(Ext.GetBloon("BfbFortified").id, 50);
            }
            if (round == 17)
            {
                roundModel.AddBloonGroup(Ext.GetBloon("Ddt").id, 50);
            }
            if (round == 18)
            {
                roundModel.AddBloonGroup(Ext.GetBloon("ZomgFortified").id, 50);
            }
            if (round == 19)
            {
                roundModel.AddBloonGroup(Ext.GetBloon("DdtFortified").id, 50);
            }
            if (round == 20)
            {
                roundModel.AddBloonGroup(Ext.GetBloon("Bad").id, 50);
            }
            if (round == 21)
            {
                roundModel.AddBloonGroup(Ext.GetBloon("BadFortified").id, 50);
            }
        }
    }
    internal class BPIR : ModRoundSet
    {
        public override string BaseRoundSet => RoundSetType.Empty;

        public override string Icon => "BPI";

        public override int DefinedRounds => 101;

        public override void ModifyRoundModels(RoundModel roundModel, int round)
        {
            if (round == 1)
            {
                roundModel.AddBloonGroup(Ext.GetBloon("Red").id, 100);
            }
            if (round == 2)
            {
                roundModel.AddBloonGroup(Ext.GetBloon("Blue").id, 100);
            }
            if (round == 3)
            {
                roundModel.AddBloonGroup(Ext.GetBloon("Green").id, 100);
            }
            if (round == 4)
            {
                roundModel.AddBloonGroup(Ext.GetBloon("Yellow").id, 100);
            }
            if (round == 5)
            {
                roundModel.AddBloonGroup(Ext.GetBloon("Pink").id, 100);
            }
            if (round == 6)
            {
                roundModel.AddBloonGroup(Ext.GetBloon("White").id, 50);
                roundModel.AddBloonGroup(Ext.GetBloon("Black").id, 50);
            }
            if (round == 7)
            {
                roundModel.AddBloonGroup(Ext.GetBloon("Purple").id, 100);
            }
            if (round == 8)
            {
                roundModel.AddBloonGroup(Ext.GetBloon("Zebra").id, 100);
            }
            if (round == 9)
            {
                roundModel.AddBloonGroup(Ext.GetBloon("Lead").id, 100);
            }
            if (round == 10)
            {
                roundModel.AddBloonGroup(Ext.GetBloon("Rainbow").id, 100);
            }
            if (round == 11)
            {
                roundModel.AddBloonGroup(Ext.GetBloon("Ceramic").id, 100);
            }
            if (round == 12)
            {
                roundModel.AddBloonGroup(Ext.GetBloon("Moab").id, 100);
            }
            if (round == 13)
            {
                roundModel.AddBloonGroup(Ext.GetBloon("Bfb").id, 100);
            }
            if (round == 14)
            {
                roundModel.AddBloonGroup(Ext.GetBloon("MoabFortified").id, 100);
            }
            if (round == 15)
            {
                roundModel.AddBloonGroup(Ext.GetBloon("Zomg").id, 100);
            }
            if (round == 16)
            {
                roundModel.AddBloonGroup(Ext.GetBloon("BfbFortified").id, 100);
            }
            if (round == 17)
            {
                roundModel.AddBloonGroup(Ext.GetBloon("Ddt").id, 100);
            }
            if (round == 18)
            {
                roundModel.AddBloonGroup(Ext.GetBloon("ZomgFortified").id, 100);
            }
            if (round == 19)
            {
                roundModel.AddBloonGroup(Ext.GetBloon("DdtFortified").id, 100);
            }
            if (round == 20)
            {
                roundModel.AddBloonGroup(Ext.GetBloon("Bad").id, 100);
            }
            if (round >= 21)
            {
                roundModel.AddBloonGroup(Ext.GetBloon("BadFortified").id, 100);
            }
        }
    }
}
