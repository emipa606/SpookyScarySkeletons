using HarmonyLib;
using UnityEngine;
using Verse;

namespace ReplaceSkeletons.Patches;

[HarmonyPatch(typeof(PawnRenderNode_Head), nameof(PawnRenderNode_Head.GraphicFor))]
public class PawnGraphicSet_ResolveAllGraphics
{
    private static void Postfix(Pawn pawn, ref Graphic __result)
    {
        if (pawn.Drawer.renderer.CurRotDrawMode == RotDrawMode.Dessicated &&
            pawn.story?.headType.defName.ToLower().Contains("narrow") == true)
        {
            __result = HeadTypeDefOf.NarrowSkull.GetGraphic(pawn, Color.white);
        }
    }
}