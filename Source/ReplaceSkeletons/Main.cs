using System.Reflection;
using HarmonyLib;
using Verse;

namespace ReplaceSkeletons;

[StaticConstructorOnStartup]
public static class Main
{
    static Main()
    {
        new Harmony("net.funkyshit.replaceskeletons").PatchAll(Assembly.GetExecutingAssembly());
    }
}