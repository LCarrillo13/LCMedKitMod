using GameNetcodeStuff;
using HarmonyLib;


namespace LCMedKitMod.Patches
{
    [HarmonyPatch(typeof(PlayerControllerB))]
    public class PlayerControllerBPatch
    {
        [HarmonyPatch("Update")]
        [HarmonyPostfix]
        static void medKitPatch()
        {
            
        }
    }
}