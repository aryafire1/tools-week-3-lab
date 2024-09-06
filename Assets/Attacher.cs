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
    public override void OnInspectorGUI() {
        base.OnInspectorGUI();

        if (GUILayout.Button("Select all")) {
            var allButtonEditor = GameObject.FindObjectsOfType<Attacher>();
            Selection.objects = allButtonEditor;
        }
    }
}

#endif
