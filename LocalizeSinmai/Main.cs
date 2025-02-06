using System;
using MelonLoader;
using LocalizeSinmai.Fix;
using System.Reflection;
namespace LocalizeSinmai
{
    public static class BuildInfo
    {
        public const string Name = "LocalizeSinmai";
        public const string Description = "Sinmai Chinese Localization";
        public const string Author = "SoulGateKey";
        public const string Company = null;
        public const string Version = "1.0.0";
        public const string DownloadLink = null;
    }

    public class LocalizeSinmai : MelonMod
    {   
        private static bool _hasErrors;
        public void Patch(Type type, bool isNested = false)
        {
            MelonLogger.Msg($"> Patching {type}");
            try
            {
                HarmonyInstance.PatchAll(type);
                foreach (var nested in type.GetNestedTypes())
                {
                    Patch(nested, true);
                }

                var customMethod = type.GetMethod("DoCustomPatch", BindingFlags.Public | BindingFlags.Static);
                customMethod?.Invoke(null, [HarmonyInstance]);
            }
            catch (Exception e)
            {
                MelonLogger.Error($"Failed to patch {type}: {e}");
                _hasErrors = true;
            }
            //HarmonyLib.Harmony.CreateAndPatchAll(type);
        }

        private static void ApplyPatch()
        {
            //似乎仅在需要加载配置文件时需要写
        }

        public override void OnInitializeMelon()
        {
            MelonLogger.Msg("Loading mod settings...");
            Patch(typeof(FontFix));
            MelonLogger.Msg("Loaded!");
        }
    }
}