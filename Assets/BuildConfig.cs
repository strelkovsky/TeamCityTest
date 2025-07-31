using UnityEditor;
using UnityEngine;
#if UNITY_EDITOR

[CreateAssetMenu(fileName = "BuildConfig", menuName = "Build Config")]
public class BuildConfig : ScriptableObject
{
    [SerializeField] private string _buildName;
    
    public void Build()
    {
        Debug.Log("Starting Unity build...");

        string[] scenes = new[] { "Assets/Scenes/SampleScene.unity" };
        string buildPath = $"Builds/Windows/{_buildName}.exe";

        BuildPipeline.BuildPlayer(scenes, buildPath, BuildTarget.StandaloneWindows64, BuildOptions.None);

        Debug.Log("Build finished.");
    }
}

#endif