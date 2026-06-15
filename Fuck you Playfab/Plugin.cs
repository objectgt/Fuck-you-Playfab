using BepInEx;
using GorillaNetworking;
using HarmonyLib;

namespace Fuck_you_Playfab
{
    [BepInPlugin(Constants.GUID, Constants.Name, Constants.Version)]
    public class Plugin : BaseUnityPlugin
    {
        void Awake()
        {
            Harmony harmony = new Harmony(Constants.GUID);
            harmony.PatchAll();
        }
    }

    [HarmonyPatch(typeof(PlayFabAuthenticator), "Awake")]
    class incinerateplayfab
    {
        [HarmonyPrefix]
        public static bool patchplayfabauthenticator()
        {
            return false;
        }
    }
}
