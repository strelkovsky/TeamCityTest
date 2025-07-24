using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BuildTest : MonoBehaviour
{
    // Start is called before the first frame update

    [ContextMenu("Build Test")]
    public void Build()
    {
        #if UNITY_EDITOR
        BuildEntry.PerformBuild();
        #endif
    }
}
