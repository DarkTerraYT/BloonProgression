using Il2CppAssets.Scripts.Models.Bloons;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Unity;
using Il2CppSystem;
using System.ComponentModel;

namespace Extension
{
    // Class I Copy With Helpful Things For Modding
    internal class Ext
    {
        [Description("Gets The Display From The Bloon/Tower With The ID. Type 0 = Bloon, Type 1 = Tower")]
        public static string GetDisplay(string id, int type)
        {
            if (type == 0)
            {
                return Game.instance.model.GetBloon(id).display.GUID;
            }
            if (type == 1)
            {
                return Game.instance.model.GetTower(id).display.GUID;
            }
            else
            {
                new ArgumentOutOfRangeException("type", "Type Must be 0 or 1");
                return "";
            }
        }
        [Description("Gets a TowerModel With The Tower ID")]
        public static TowerModel GetTower(string id, int topUpgrades = 0, int middleUpgrades = 0, int bottomUpgrades = 0)
        {
            return Game.instance.model.GetTower(id, topUpgrades, middleUpgrades, bottomUpgrades);
        }
        [Description("Gets a BloonModel With The Bloon ID")]
        public static BloonModel GetBloon(string id)
        {
            return Game.instance.model.GetBloon(id);
        }
    }
}
