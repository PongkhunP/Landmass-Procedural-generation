using System.Collections;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(MapGenerator))]
public class MapGeneratorEditor : Editor
{
    public override void OnInspectorGUI()
    {
        MapGenerator mapGen = (MapGenerator)target;

        if(DrawDefaultInspector()) // if any value was change
        {
            if(mapGen.autoUpdate) //if auto update is true
            {
                mapGen.GenerateMap(); // update automatically
            }
        }
        if(GUILayout.Button("Generate")) // draw custom button UI on any MapGenerator
        {
            mapGen.GenerateMap(); // if press generate noiseMap
        }
        base.OnInspectorGUI();
    }
}
