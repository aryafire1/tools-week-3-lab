using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(things)), CanEditMultipleObjects]
public class buttoneditor : Editor
{
    public override void OnInspectorGUI() {
        base.OnInspectorGUI();

        if (GUILayout.Button("Select all")) {
            var allButtonEditor = GameObject.FindObjectsOfType<buttoneditor>();
            var allButtonGameObjects = allButtonEditor
                .Select(t => t.gameObject).ToArray();
            Selection.objects = allButtonGameObjects;
        }
    }
}
