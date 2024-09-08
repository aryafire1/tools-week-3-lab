using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class Attacher : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

#if UNITY_EDITOR
[CustomEditor(typeof(Attacher)), CanEditMultipleObjects]
public class AttacherEditor : Editor
{
    float sizeMultiplier = 1.0f;

    [MenuItem("Examples/Scale selected Object")]
    public override void OnInspectorGUI() {
        base.OnInspectorGUI();

        EditorGUILayout.BeginHorizontal();

        if (GUILayout.Button("Select all")) {
            var allButtonEditor = GameObject.FindObjectsOfType<Attacher>();
            Selection.objects = allButtonEditor;
        }
        if (GUILayout.Button("Clear selection")) {
            Selection.objects = new Object[] { (target as Attacher).gameObject };
        }

        EditorGUILayout.EndHorizontal();

        using (new EditorGUILayout.HorizontalScope()) {

        if (GUILayout.Button("Disable/Enable all", GUILayout.Height(40))) {
            foreach (var obj in GameObject.FindObjectsOfType<Attacher>(true)) {
                obj.gameObject.SetActive(!obj.gameObject.activeSelf);
            }
        }

        }
        
        sizeMultiplier = EditorGUILayout.FloatField("Set Scale:", sizeMultiplier);

        if(sizeMultiplier<=2 && sizeMultiplier >=1)
        {
            
        }
        else{
            EditorGUILayout.HelpBox("Must be smaller than 2 and bigger than 1", MessageType.Warning);
        }
        
    }
}

#endif
