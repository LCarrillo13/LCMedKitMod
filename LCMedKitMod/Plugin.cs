using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using LCMedKitMod.Patches;

namespace LCMedKitMod
{
    [BepInPlugin(modGUID, modName, modVersion)]
    public class MedKitModBase : BaseUnityPlugin
    {
        
        // Mod base setup
        // GUID must be UNIQUE
        private const string modGUID = "Zeus.MedKitMod";
        private const string modName = "MedKit Mod";
        private const string modVersion = "1.0.0";
        
        private readonly Harmony harmony = new Harmony(modGUID);

        private static MedKitModBase Instance;

        internal ManualLogSource mls;
        
        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
            }

            mls = BepInEx.Logging.Logger.CreateLogSource(modGUID);
            
            mls.LogInfo("Mod loaded successfully");
            
            harmony.PatchAll(typeof(MedKitModBase));
            
            // TODO : delete comment when patch is debugged
            harmony.PatchAll(typeof(PlayerControllerBPatch));
            // harmony.PatchAll(typeof(ItemPatch));
            
        }
    }
}