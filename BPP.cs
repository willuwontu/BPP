﻿using BepInEx;
using UnboundLib;
using HarmonyLib;
using CardChoiceSpawnUniqueCardPatch.CustomCategories;

namespace BPP
{
    [BepInDependency("com.willis.rounds.unbound", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("pykess.rounds.plugins.moddingutils", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("pykess.rounds.plugins.cardchoicespawnuniquecardpatch", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("io.olavim.rounds.mapsextended", BepInDependency.DependencyFlags.HardDependency)]

    [BepInPlugin(ModId, ModName, Version)]

    [BepInProcess("Rounds.exe")]
    public class BPP : BaseUnityPlugin
    {
        private const string ModId = "com.binarypenialporty.rounds.bpp";
        private const string ModName = "BPP";
        public const string Version = "0.3.5";
        public const string ModInitials = "BPP";

        public static BPP instance { get; private set; }


        void Awake()
        {
            // Use this to call any harmony patch files your mod may have
            var harmony = new Harmony(ModId);
            harmony.PatchAll();
        }
        void Start()
        {
            instance = this;

            //Added a class specifically for initializing cards, because it was getting messy.

            Initialize.Cards();
        }
    }
}
