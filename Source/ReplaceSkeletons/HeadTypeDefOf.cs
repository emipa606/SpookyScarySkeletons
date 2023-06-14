using RimWorld;
using Verse;

namespace ReplaceSkeletons.Patches;

[DefOf]
public static class HeadTypeDefOf
{
    public static HeadTypeDef NarrowSkull;

    static HeadTypeDefOf()
    {
        DefOfHelper.EnsureInitializedInCtor(typeof(HeadTypeDefOf));
    }
}