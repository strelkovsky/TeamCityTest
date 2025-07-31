using System;
using System.Linq;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;

#if UNITY_EDITOR
public static class BuildEntry
{
    public static void PerformBuild()
    {
        string configPath = Environment.GetCommandLineArgs()
            .FirstOrDefault(arg => arg.StartsWith("-buildConfig="))?
            .Replace("-buildConfig=", "");

        if (string.IsNullOrEmpty(configPath))
        {
            Debug.LogError("Missing -buildConfig=... parameter");
            return;
        }

        var config = AssetDatabase.LoadAssetAtPath<BuildConfig>(configPath);
        if (config == null)
        {
            Debug.LogError($"Config not found at path: {configPath}");
            return;
        }

        config.Build();
    }
}
#endif