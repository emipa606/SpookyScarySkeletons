using HarmonyLib;
using UnityEngine;
using Verse;

namespace ReplaceSkeletons.Patches;

[HarmonyPatch(typeof(PawnGraphicSet))]
[HarmonyPatch("ResolveAllGraphics")]
public class PawnGraphicSet_ResolveAllGraphics
{
    private static void Postfix(ref PawnGraphicSet __instance)
    {
        if (__instance.pawn?.story?.headType.defName.ToLower().Contains("narrow") == true)
        {
            __instance.skullGraphic = HeadTypeDefOf.NarrowSkull.GetGraphic(Color.white, true);
        }
    }
}