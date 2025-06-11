using HarmonyLib;

namespace SuperMonke.Patches
{
    //i need to make sure the scene is loaded
    [HarmonyPatch(typeof(GorillaLocomotion.GTPlayer))]
    [HarmonyPatch("Awake")]
    class SuperMonkePlayerPatch
    {
        private static void Postfix(GorillaLocomotion.GTPlayer __instance)
        {
            __instance.gameObject.AddComponent<Behaviours.SuperMonke>();
        }
    }
}
