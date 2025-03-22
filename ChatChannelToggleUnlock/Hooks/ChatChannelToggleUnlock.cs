using HarmonyLib;
using Il2Cpp;

namespace ChatChannelToggleUnlock.Hooks
{
    [HarmonyPatch(typeof(UIChatChannelListItem), nameof(UIChatChannelListItem.IsInteractable))]
    internal static class ChatChannelToggleUnlock
    {
        [HarmonyPrefix]
        private static bool Prefix(ref bool __result)
        {
            __result = true;
            return false;
        }
    }
}