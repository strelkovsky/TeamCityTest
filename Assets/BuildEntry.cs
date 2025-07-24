using UnityEditor;
using UnityEngine;

public static class BuildEntry
{
    // Вызывается из TeamCity: -executeMethod BuildEntry.PerformBuild
    public static void PerformBuild()
    {
        // Загрузи ассет (можно передать имя или путь через параметр)
        var config = AssetDatabase.LoadAssetAtPath<BuildConfig>("Assets/BuildConfig.asset");

        if (config == null)
        {
            Debug.LogError("BuildConfig asset not found!");
            return;
        }

        config.Build();
    }
}