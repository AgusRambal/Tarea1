using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(RandomColor))]
public class CubeEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        RandomColor randomColor = (RandomColor)target; 

        if (GUILayout.Button("Generate Color"))
        {
            randomColor.GenerateColor();
            Debug.Log("Presione generate color");
        }
    }
}
 