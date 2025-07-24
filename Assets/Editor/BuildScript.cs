using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BuildScript 
{
    public static void PerformBuild()
    {
        Debug.Log("Starting Unity build...");

        string[] scenes = new[] { "Assets/Scenes/SampleScene.unity" };
        string buildPath = "Builds/Windows/MyGame.exe";

        BuildPipeline.BuildPlayer(scenes, buildPath, BuildTarget.StandaloneWindows64, BuildOptions.None);

        Debug.Log("Build finished.");
    }
}
