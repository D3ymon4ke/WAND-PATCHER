using System;
using System.Reflection;

namespace WandEnhancer
{
    public static class Constants
    {
        public const string RepoName = "WAND-PATCHER";
        public const string Owner = "D3ymon4ke";
        public const string Author = "Lucas Machado";
        public static readonly string RepositoryUrl = $"https://github.com/{Owner}/{RepoName}";
        public static readonly Version Version;

        public static readonly string Build;

        public static readonly string[] WeModBrandNames = { "Wand", "WeMod" };
        public const string AppSettingsFileName = "appsettings.json";
        public const string AutoPatchConfigFileName = "enhancer.json";

        static Constants()
        {
            Version = Assembly.GetExecutingAssembly().GetName().Version;
            Build = string.IsNullOrEmpty(BuildStamp.Value) ? "unofficial" : BuildStamp.Value;
        }
    }
}
