using BepInEx;
using System;
using System.Reflection;
using UnityEngine;

namespace NextOfKinHaveInfantileMod
{
    [BepInPlugin(GUID, NAME, VERSION)]
    public class Plugin : BaseUnityPlugin
    {
        public const string GUID = "SpecialAPI.NextOfKinHaveInfantileMod";
        public const string NAME = "Next of Kin have Infantile Mod";
        public const string VERSION = "1.0.0";

        public void Awake()
        {
            LoadedAssetsHandler.GetEnemy("NextOfKin_EN").passiveAbilities.Add(LoadedAssetsHandler.GetPassive("Infantile_PA"));
        }
    }
}
