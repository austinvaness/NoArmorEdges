using HarmonyLib;
using Sandbox.Game.Entities;

[HarmonyPatch(typeof(MyCubeGrid), "AddBlockEdges")]
public static class Patch_DisableEdges
{
    public static bool Prefix()
    {
        return false;
    }
}